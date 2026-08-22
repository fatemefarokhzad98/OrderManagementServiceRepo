using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace OrderManagementService.Api.ErrorHandling;

public sealed class GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger, IHostEnvironment environment) : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
        var statusCode = exception switch
        {
            ArgumentException => StatusCodes.Status400BadRequest,

            InvalidOperationException => StatusCodes.Status409Conflict,

            KeyNotFoundException => StatusCodes.Status404NotFound,
            _ =>
                StatusCodes.Status500InternalServerError
        };

        if (statusCode >= 500)
            logger.LogError(exception, "Unhandled exception. TraceId={TraceId}", httpContext.TraceIdentifier);

        else
            logger.LogWarning(exception, "Request failed. TraceId={TraceId}", httpContext.TraceIdentifier);



        var problemDetails = new ProblemDetails
        {
            Status = statusCode,
            Title = statusCode switch
            {
                StatusCodes.Status400BadRequest => "درخواست نامعتبر",

                StatusCodes.Status404NotFound => "منبع پیدا نشد",

                StatusCodes.Status409Conflict => "تداخل در عملیات",
                _ => "خطای داخلی سرور"
            },

            Detail = GetDetail(exception, statusCode),

            Instance = httpContext.Request.Path
        };

        problemDetails.Extensions["code"] = statusCode == 500 ? "Server.Unexpected" : "Request.Invalid";

        problemDetails.Extensions["traceId"] = httpContext.TraceIdentifier;

        httpContext.Response.StatusCode = statusCode;

        await httpContext.Response.WriteAsJsonAsync(problemDetails, cancellationToken);

        return true;
    }

    private string GetDetail(Exception exception, int statusCode)
    {
        if (statusCode < 500)
            return exception.Message;

        return environment.IsDevelopment() ? exception.Message : "خطایی غیرمنتظره در سرور رخ داده است.";

    }
}