using System.ComponentModel.DataAnnotations;

namespace OrderManagementService.Api.Models.Requests
{
    public class CreateOrderRequestModel
    {
        [Range(1, long.MaxValue)]
        public long CustomerId { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "حداقل یک محصول باید انتخاب شود.")]
        public IReadOnlyCollection<CreateOrderItemRequestModel> Items { get; set; } = [];


    }
}
