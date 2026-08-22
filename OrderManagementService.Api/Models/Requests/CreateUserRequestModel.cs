using System.ComponentModel.DataAnnotations;

namespace OrderManagementService.Api.Models.Requests
{
    public class CreateUserRequestModel
    {
        [Required(ErrorMessage = "نام کاربری الزامی است.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "نام کاربری باید بین ۳ تا ۱۰۰ کاراکتر باشد.")]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = "رمز عبور الزامی است.")]
        [StringLength(256, MinimumLength = 8, ErrorMessage = "رمز عبور باید حداقل ۸ کاراکتر باشد.")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "نقش کاربر الزامی است.")]
        [MinLength(1, ErrorMessage = "حداقل یک نقش باید انتخاب شود.")]

        public IReadOnlyCollection<long> RoleIds { get; set; } = [];
    }
}
