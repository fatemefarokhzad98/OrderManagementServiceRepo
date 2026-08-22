using OrderManagementService.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.DTOs.Order.Responses
{
  public class OrderDetailResponse
    {
        public long Id { get; set; }

        public long CustomerId { get; set; }

        public OrderStatus Status { get; set; }

        public decimal TotalAmount { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public IReadOnlyCollection<OrderItemResponse> Items { get; set; } = [];

    }
}
