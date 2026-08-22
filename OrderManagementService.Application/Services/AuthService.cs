using OrderManagementService.Application.Common.Results;
using OrderManagementService.Application.Contracts.Authentication;
using OrderManagementService.Application.Contracts.Persistence;
using OrderManagementService.Application.Contracts.Services;
using OrderManagementService.Application.DTOs.Authentication.Requests;
using OrderManagementService.Application.DTOs.Authentication.Responses;
using OrderManagementService.Domain.Entities;

namespace OrderManagementService.Application.Services;

public sealed class AuthService(
    IUserRepository userRepository,
    IRefreshTokenRepository refreshTokenRepository,
    IJwtTokenGenerator jwtTokenGenerator,
    IPasswordService passwordService,
    IUnitOfWork unitOfWork) : IAuthService
{
    public async Task<OperationResult<TokenResponse>> LoginAsync(LoginRequest request, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(request.Username) || string.IsNullOrWhiteSpace(request.Password))

            return InvalidCredentials();

        var username = request.Username.Trim();
        var user = await userRepository.GetByUsernameWithRolesAsync(username, cancellationToken);

        if (user is null || !user.IsActive)
            return InvalidCredentials();

        var passwordIsValid = passwordService.Verify(user.PasswordHash, request.Password);

        if (!passwordIsValid)
            return InvalidCredentials();

        var tokenResult =
            jwtTokenGenerator.GenerateTokens(user);

        var refreshToken = CreateRefreshToken(tokenResult, user.Id);

        await refreshTokenRepository.AddAsync(refreshToken, cancellationToken);

        var commitResult = await unitOfWork.CommitAsync(cancellationToken);
        if (commitResult.IsFailure)
            return OperationResult<TokenResponse>.Failure(commitResult.Error);

        return OperationResult<TokenResponse>.Success(CreateTokenResponse(tokenResult));

    }

    public async Task<OperationResult<TokenResponse>> RefreshAsync(RefreshTokenRequest request, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(request.RefreshToken))
            return InvalidRefreshToken("رفرش توکن الزامی است.");
        var tokenHash = jwtTokenGenerator.HashRefreshToken(request.RefreshToken);
        var currentRefreshToken = await refreshTokenRepository.GetByTokenHashWithUserAndRolesAsync(tokenHash, cancellationToken);
        if (currentRefreshToken is null)
            return InvalidRefreshToken("رفرش توکن معتبر نیست.");
        if (!currentRefreshToken.IsActive)
            return InvalidRefreshToken("رفرش توکن منقضی یا باطل شده است.");
        if (!currentRefreshToken.User.IsActive)
            return OperationResult<TokenResponse>.Failure(new Error("Auth.UserInactive", "کاربر غیرفعال است."));
        currentRefreshToken.Revoke();
        var tokenResult = jwtTokenGenerator.GenerateTokens(currentRefreshToken.User);

        var newRefreshToken = CreateRefreshToken(tokenResult, currentRefreshToken.UserId);

        await refreshTokenRepository.AddAsync(newRefreshToken, cancellationToken);

        var commitResult = await unitOfWork.CommitAsync(cancellationToken);
        if (commitResult.IsFailure)
            return OperationResult<TokenResponse>.Failure(commitResult.Error);
        return OperationResult<TokenResponse>.Success(CreateTokenResponse(tokenResult));
    }

    public async Task<OperationResult> LogoutAsync(RefreshTokenRequest request, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(request.RefreshToken))
            return OperationResult.Failure(new Error("Auth.InvalidRefreshToken", "رفرش توکن الزامی است."));
        var tokenHash = jwtTokenGenerator.HashRefreshToken(request.RefreshToken);

        var refreshToken = await refreshTokenRepository.GetByTokenHashAsync(tokenHash, cancellationToken);

        if (refreshToken is null || !refreshToken.IsActive)
            return OperationResult.Failure(new Error("Auth.InvalidRefreshToken", "رفرش توکن معتبر نیست."));

        refreshToken.Revoke();

        var commitResult = await unitOfWork.CommitAsync(cancellationToken);

        if (commitResult.IsFailure)
        
            return OperationResult.Failure(commitResult.Error);
        return OperationResult.Success();
    }

    #region Private Method

    #endregion
    private RefreshToken CreateRefreshToken(TokenResult tokenResult, long userId)
    {
        var refreshTokenHash = jwtTokenGenerator.HashRefreshToken(tokenResult.RefreshToken);

        return new RefreshToken(
            refreshTokenHash,
            tokenResult.RefreshTokenExpiresAt,
            userId);
    }

    private static TokenResponse CreateTokenResponse(TokenResult tokenResult)
    {
        return new TokenResponse
        {
            AccessToken = tokenResult.AccessToken,
            AccessTokenExpiresAt = tokenResult.AccessTokenExpiresAt,
            RefreshToken = tokenResult.RefreshToken,
            RefreshTokenExpiresAt = tokenResult.RefreshTokenExpiresAt

        };
    }

    private static OperationResult<TokenResponse> InvalidCredentials()
    {
        return OperationResult<TokenResponse>.Failure(new Error("Auth.InvalidCredentials", "نام کاربری یا رمز عبور صحیح نیست."));

    }

    private static OperationResult<TokenResponse> InvalidRefreshToken(string message)
    {
        return OperationResult<TokenResponse>.Failure(new Error("Auth.InvalidRefreshToken", message));
    }

}