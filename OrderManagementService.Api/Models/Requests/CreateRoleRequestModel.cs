using System.ComponentModel.DataAnnotations;

namespace OrderManagementService.Api.Models.Requests
{
    public class CreateRoleRequestModel
    {
        [Required(ErrorMessage = "نام نقش الزامی است.")]
        [StringLength(50, ErrorMessage = "نام نقش حداکثر ۵۰ کاراکتر است.")]
        public string Name { get; set; } = null!;
    }
}
