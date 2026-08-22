using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using OrderManagementService.Application.Common.Results;
using OrderManagementService.Application.Contracts.Authentication;
using OrderManagementService.Application.Contracts.Persistence;
using OrderManagementService.Domain.Entities;
using OrderManagementService.Infrastructure.Authentication;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Infrastructure.Services
{
    public class JwtTokenGenerator(IOptions<JwtOptions> jwtOptions) : IJwtTokenGenerator
    {
        private readonly JwtOptions _jwtOptions = jwtOptions.Value;

        public TokenResult GenerateTokens(User user)
        {
            ArgumentNullException.ThrowIfNull(user);

            var now = DateTime.UtcNow;

            var accessTokenExpiresAt = now.AddMinutes(_jwtOptions.AccessTokenExpirationMinutes);


            var refreshTokenExpiresAt = now.AddDays(_jwtOptions.RefreshTokenExpirationDays);


            return new TokenResult
            {
                AccessToken = GenerateAccessToken(user, now, accessTokenExpiresAt),

                AccessTokenExpiresAt = accessTokenExpiresAt,

                RefreshToken = GenerateRefreshToken(),

                RefreshTokenExpiresAt = refreshTokenExpiresAt
            };
        }

        public string HashRefreshToken(string refreshToken)
        {
            if (string.IsNullOrWhiteSpace(refreshToken))
            {
                throw new ArgumentException("Refresh token is required.", nameof(refreshToken));

            }

            var tokenBytes = Encoding.UTF8.GetBytes(refreshToken);

            var hashBytes = SHA256.HashData(tokenBytes);

            return Convert.ToHexString(hashBytes);
        }

        private string GenerateAccessToken(User user, DateTime issuedAt, DateTime expiresAt)
        {
            var claims = CreateClaims(user);

            var secretKeyBytes = Encoding.UTF8.GetBytes(_jwtOptions.SecretKey);


            var securityKey = new SymmetricSecurityKey(secretKeyBytes);


            var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var jwt = new JwtSecurityToken(
                issuer: _jwtOptions.Issuer,
                audience: _jwtOptions.Audience,
                claims: claims,
                notBefore: issuedAt,
                expires: expiresAt,
                signingCredentials: signingCredentials);

            return new JwtSecurityTokenHandler()
                .WriteToken(jwt);
        }

        private static List<Claim> CreateClaims(User user)
        {
            var claims = new List<Claim>
        {
            new(
                JwtRegisteredClaimNames.Sub,   user.Id.ToString()),
            new(
                JwtRegisteredClaimNames.UniqueName,  user.Username),
            new(
                JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new(
                ClaimTypes.NameIdentifier,   user.Id.ToString()),
            new(
                ClaimTypes.Name,   user.Username)

        };

            var activeRoleNames = user.Roles
                .Where(role => role.IsActive)
                .Select(role => role.Name)
                .Distinct(StringComparer.OrdinalIgnoreCase);

            foreach (var roleName in activeRoleNames)
            {
                claims.Add(new Claim(ClaimTypes.Role, roleName));

            }

            return claims;
        }

        private static string GenerateRefreshToken()
        {
            var randomBytes = RandomNumberGenerator.GetBytes(64);

            return Base64UrlEncoder.Encode(randomBytes);
        }
    }
}
