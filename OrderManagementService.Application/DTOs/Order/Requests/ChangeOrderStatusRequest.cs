using OrderManagementService.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.DTOs.Order.Requests
{
  public  class ChangeOrderStatusRequest
    {
        public OrderStatus Status { get; set; }

    }
}
