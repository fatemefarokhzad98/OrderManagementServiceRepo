using OrderManagementService.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace OrderManagementService.Api.Models.Requests
{
    public class ChangeOrderStatusRequestModel
    {
        [EnumDataType(typeof(OrderStatus))]
        public OrderStatus Status { get; set; }
    }
}
