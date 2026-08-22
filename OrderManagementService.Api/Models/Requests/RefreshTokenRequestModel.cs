using System.ComponentModel.DataAnnotations;

namespace OrderManagementService.Api.Models.Requests
{
    public class RefreshTokenRequestModel
    {
        [Required(ErrorMessage = "رفرش توکن الزامی است.")]
        public string RefreshToken { get; set; } = null!;
    }
}
