namespace OrderManagementService.Api.Models.Responses
{
    public class TokenResponseModel
    {
        public string TokenType { get; set; } = "Bearer";

        public string AccessToken { get; set; } = null!;

        public DateTime AccessTokenExpiresAt { get; set; }

        public string RefreshToken { get; set; } = null!;

        public DateTime RefreshTokenExpiresAt { get; set; }
    }
}
