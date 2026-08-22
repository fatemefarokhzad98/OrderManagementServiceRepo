using System.ComponentModel.DataAnnotations;

namespace OrderManagementService.Api.Models.Requests
{
    public class CreateProductRequestModel
    {

        [Required(ErrorMessage = "نام محصول الزامی است.")]
        [StringLength(100, ErrorMessage = "نام محصول حداکثر ۱۰۰ کاراکتر است.")]

        public string Name { get; set; } = null!;
        [StringLength(500, ErrorMessage = "توضیحات حداکثر ۵۰۰ کاراکتر است.")]

        public string? Description { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "قیمت نمی‌تواند منفی باشد.")]

        public decimal Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "موجودی اولیه نمی‌تواند منفی باشد.")]

        public int InitialQuantity { get; set; }
    }
}
