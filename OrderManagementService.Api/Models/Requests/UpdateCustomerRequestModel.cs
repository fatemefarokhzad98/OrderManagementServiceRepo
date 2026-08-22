using System.ComponentModel.DataAnnotations;

namespace OrderManagementService.Api.Models.Requests
{
    public class UpdateCustomerRequestModel
    {
        [Required(ErrorMessage = "نام الزامی است.")]
        [StringLength(100)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "نام خانوادگی الزامی است.")]
        [StringLength(100)]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "شماره تلفن الزامی است.")]
        [StringLength(11)]
        public string PhoneNumber { get; set; } = null!;
    }
}
