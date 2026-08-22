using System.ComponentModel.DataAnnotations;

namespace OrderManagementService.Api.Models.Requests
{
    public class IncreaseInventoryRequestModel
    {
        [Range(1, int.MaxValue, ErrorMessage = "مقدار افزایش باید بیشتر از صفر باشد.")]

        public int Quantity { get; set; }
    }
}
