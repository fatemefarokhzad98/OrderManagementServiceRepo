using System.ComponentModel.DataAnnotations;

namespace OrderManagementService.Api.Models.Requests
{
    public class CreateCustomerRequestModel
    {

        [Required(ErrorMessage = "نام الزامی است.")]
        [StringLength(100, ErrorMessage = "نام حداکثر ۱۰۰ کاراکتر است.")]

        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "نام خانوادگی الزامی است.")]
        [StringLength(100, ErrorMessage = "نام خانوادگی حداکثر ۱۰۰ کاراکتر است.")]

        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "شماره تلفن الزامی است.")]
        [StringLength(11, ErrorMessage = "شماره تلفن حداکثر ۱۱ کاراکتر است.")]

        public string PhoneNumber { get; set; } = null!;
    }
}
