using System.ComponentModel.DataAnnotations;

namespace OrderManagementService.Api.Models.Requests
{
    public class LoginRequestModel
    {
        [Required(ErrorMessage = "نام کاربری الزامی است.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "نام کاربری معتبر نیست.")]
        public string UserName { get; set; } = null!;

        [Required(ErrorMessage = "رمز عبور الزامی است.")]
        [StringLength(256, MinimumLength = 1, ErrorMessage = "رمز عبور معتبر نیست.")]
        public string Password { get; set; } = null!;
    }
}
