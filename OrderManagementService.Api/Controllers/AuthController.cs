using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrderManagementService.Api.Models.Requests;
using OrderManagementService.Api.Models.Responses;
using OrderManagementService.Application.Contracts.Services;
using OrderManagementService.Application.DTOs.Authentication.Requests;
using OrderManagementService.Application.DTOs.Authentication.Responses;

namespace OrderManagementService.Api.Controllers;

[ApiController]
[Route("api/v1/auth")]
[ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
public sealed class AuthController(IAuthService authService) : ApiControllerBase
{
    [AllowAnonymous]
    [HttpPost("login")]
    [ProducesResponseType(typeof(TokenResponseModel), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status401Unauthorized)]
    public async Task<IActionResult> Login([FromBody] LoginRequestModel request, CancellationToken cancellationToken)
    {
        var serviceRequest = new LoginRequest
        {
            Username = request.UserName,
            Password = request.Password
        };
        var result = await authService.LoginAsync(serviceRequest, cancellationToken);

        if (result.IsFailure)
            return Failure(result.Error);
        return Ok(MapResponse(result.Value!));
    }

    [AllowAnonymous]
    [HttpPost("refresh")]
    [ProducesResponseType(typeof(TokenResponseModel), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> Refresh([FromBody] RefreshTokenRequestModel request, CancellationToken cancellationToken)
    {
        var serviceRequest = new RefreshTokenRequest
        {
            RefreshToken = request.RefreshToken
        };

        var result = await authService.RefreshAsync(serviceRequest, cancellationToken);

        if (result.IsFailure)
            return Failure(result.Error);

        return Ok(MapResponse(result.Value!));
    }

    [AllowAnonymous]
    [HttpPost("logout")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status401Unauthorized)]
    public async Task<IActionResult> Logout([FromBody] RefreshTokenRequestModel request, CancellationToken cancellationToken)
    {
        var serviceRequest = new RefreshTokenRequest
        {
            RefreshToken = request.RefreshToken
        };
        var result = await authService.LogoutAsync(serviceRequest, cancellationToken);
        return result.IsFailure ? Failure(result.Error) : NoContent();

    }
    private static TokenResponseModel MapResponse(TokenResponse response)
    {
        return new TokenResponseModel
        {
            TokenType = "Bearer",

            AccessToken = response.AccessToken,

            AccessTokenExpiresAt = response.AccessTokenExpiresAt,

            RefreshToken = response.RefreshToken,

            RefreshTokenExpiresAt = response.RefreshTokenExpiresAt

        };
    }
}