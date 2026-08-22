using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using OrderManagementService.Api.ErrorHandling;
using OrderManagementService.Application.Contracts.Authentication;
using OrderManagementService.Application.Contracts.Persistence;
using OrderManagementService.Application.Contracts.Services;
using OrderManagementService.Application.Services;
using OrderManagementService.Infrastructure.Authentication;
using OrderManagementService.Infrastructure.EfCore;
using OrderManagementService.Infrastructure.Repository;
using OrderManagementService.Infrastructure.Services;
using Serilog;
using Serilog.Events;
using System.Security.Claims;
using System.Text;
using System.Text.Json.Serialization;

namespace OrderManagementService.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddSerilog((services, loggerConfiguration) =>
        {
        loggerConfiguration
            .ReadFrom.Configuration(builder.Configuration)
            .ReadFrom.Services(services)
            .Enrich.FromLogContext();
    });

        builder.Services.AddControllers()
         .AddJsonOptions(options =>
         {
             options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
         });
        builder.Services.AddProblemDetails();

        builder.Services.AddExceptionHandler<GlobalExceptionHandler>();

        builder.Services.Configure<ApiBehaviorOptions>(
            options =>
            {
                options.InvalidModelStateResponseFactory =
                    context =>
                    {
                        var problemDetails = new ValidationProblemDetails(context.ModelState)
                        {
                            Status = StatusCodes.Status400BadRequest,
                            Title = "خطای اعتبارسنجی",
                            Detail = "یک یا چند مقدار ورودی معتبر نیست.",
                            Instance = context.HttpContext.Request.Path
                        };

                        problemDetails.Extensions["code"] = "Validation.Failed";
                        problemDetails.Extensions["traceId"] = context.HttpContext.TraceIdentifier;
                        return new BadRequestObjectResult(problemDetails);
                    };
            });
        builder.Services.AddEndpointsApiExplorer();
        ConfigureDatabase(builder);
        ConfigureJwtOptions(builder);
        ConfigureApplicationServices(builder.Services);
        ConfigureAuthentication(builder);
        ConfigureSwagger(builder.Services);


        var app = builder.Build();
        app.UseSerilogRequestLogging(options =>
        {
            options.MessageTemplate = "HTTP {RequestMethod} {RequestPath} responded {StatusCode} in {Elapsed:0.0000} ms";
            options.GetLevel =
                (httpContext, elapsed, exception) =>
                {
                    if (exception is not null || httpContext.Response.StatusCode >= 500)
                    {
                        return LogEventLevel.Error;
                    }

                    if (httpContext.Response.StatusCode >= 400)
                    {
                        return LogEventLevel.Warning;
                    }

                    return LogEventLevel.Information;
                };

            options.EnrichDiagnosticContext = (diagnosticContext, httpContext) =>
            {
                diagnosticContext.Set("TraceId", httpContext.TraceIdentifier);

                diagnosticContext.Set("RequestHost", httpContext.Request.Host.Value);

                diagnosticContext.Set("RequestScheme", httpContext.Request.Scheme);

                diagnosticContext.Set("UserId", httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? "Anonymous");
            };
        });
        app.UseExceptionHandler();
        app.UseStatusCodePages();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        else
        {
            app.UseHsts();
        }
        app.UseHttpsRedirection();

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
    #region Private Method
    private static void ConfigureDatabase(WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        if (string.IsNullOrWhiteSpace(connectionString))
            throw new InvalidOperationException("DefaultConnection is not configured.");
        builder.Services.AddDbContext<MainDbContext>(options => options.UseSqlServer(connectionString));
    }

    private static void ConfigureJwtOptions(WebApplicationBuilder builder)
    {
        builder.Services
            .AddOptions<JwtOptions>()
            .Bind(
                builder.Configuration.GetSection(JwtOptions.SectionName))
            .Validate(
                options => !string.IsNullOrWhiteSpace(options.Issuer), "JWT Issuer is required.")

            .Validate(
                options => !string.IsNullOrWhiteSpace(options.Audience), "JWT Audience is required.")

            .Validate(
                options => Encoding.UTF8.GetByteCount(options.SecretKey ?? string.Empty) >= 32, "JWT SecretKey must be at least 32 bytes.")

            .Validate(
                options => options.AccessTokenExpirationMinutes > 0, "Access token expiration must be positive.")

            .Validate(
                options => options.RefreshTokenExpirationDays > 0, "Refresh token expiration must be positive.")
            .ValidateOnStart();
    }

    private static void ConfigureApplicationServices(IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddScoped<IPasswordService, PasswordService>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWorkWithEF>();
        services.AddScoped(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));
        services.AddScoped<ICustomerService, CustomerService>();
        services.AddScoped<IRoleService, RoleService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IInventoryService, InventoryService>();
        services.AddScoped<IOrderService, OrderService>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
    }

    private static void ConfigureAuthentication(WebApplicationBuilder builder)
    {
        var jwtOptions = builder.Configuration.GetSection(JwtOptions.SectionName)
            .Get<JwtOptions>() ?? throw new InvalidOperationException("JWT configuration is missing.");

        if (string.IsNullOrWhiteSpace(jwtOptions.Issuer))
            throw new InvalidOperationException("JWT Issuer is not configured.");

        if (string.IsNullOrWhiteSpace(jwtOptions.Audience))

            throw new InvalidOperationException("JWT Audience is not configured.");

        if (string.IsNullOrWhiteSpace(jwtOptions.SecretKey) || Encoding.UTF8.GetByteCount(jwtOptions.SecretKey) < 32)

            throw new InvalidOperationException("JWT SecretKey must be at least 32 bytes.");

        var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions.SecretKey));

        builder.Services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

        })
            .AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = true;
                options.SaveToken = false;

                options.TokenValidationParameters =
                    new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = signingKey,
                        ValidateIssuer = true,
                        ValidIssuer = jwtOptions.Issuer,
                        ValidateAudience = true,
                        ValidAudience = jwtOptions.Audience,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero,
                        NameClaimType = ClaimTypes.Name,
                        RoleClaimType = ClaimTypes.Role

                    };
            });

        builder.Services.AddAuthorization();
    }
    private static void ConfigureSwagger(IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            options.AddSecurityDefinition("Bearer",
                new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Access Token را وارد کنید."

                });

            options.AddSecurityRequirement(
                new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference =
                                new OpenApiReference
                                {
                                    Type =
                                        ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                        },
                        Array.Empty<string>()
                    }
                });
        });
    }
    #endregion


}