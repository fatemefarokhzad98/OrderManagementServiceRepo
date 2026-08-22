using System.ComponentModel.DataAnnotations;

namespace OrderManagementService.Api.Models.Requests
{
    public class BulkCreateOrderRequestModel
    {
        [Required]
        [MinLength(1)]
        public IReadOnlyCollection<CreateOrderRequestModel> Orders { get; set; } = [];
    }


}
