using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.DTOs.Order.Requests
{
  public  class CreateOrderRequest
    {
        public long CustomerId { get; set; }

        public IReadOnlyCollection<CreateOrderItemRequest> Items { get; set; } = [];

    }
}
