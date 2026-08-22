using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.DTOs.Order.Requests
{
  public  class CreateOrderItemRequest
    {
        public long ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
