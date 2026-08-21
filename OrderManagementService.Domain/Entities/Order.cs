using OrderManagementService.Domain.Common;
using OrderManagementService.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Domain.Entities
{
    public record CreateOrderItem(
        long ProductId,
        int Quantity,
        decimal UnitPrice
    );

    public record CreateOrder (long CustomerId
        , IEnumerable<CreateOrderItem> items
    );

    public class Order :BaseEntity<long>, IAuditableEntity
    {
        public Order(long customerId, IEnumerable<CreateOrderItem> orderItems)
        {
            CustomerId = customerId;
            if (orderItems.Count() == 0)
                throw new Exception();

            foreach (var item in orderItems)
            {
                _items.Add(new(Id, item.ProductId, item.Quantity, item.UnitPrice));
            }
        }

        #region Properties
        public long CustomerId { get; set; }

        public OrderStatus Status { get; private set; }

        public decimal TotalAmount => OrderItems.Sum(x => x.TotalPrice);
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        #endregion
        #region Navigation Properties
        public Customer Customer { get; set; } = null!;

        private readonly List<OrderItem> _items = [];
        public IReadOnlyCollection<OrderItem> OrderItems => _items.AsReadOnly();
        #endregion

    }
}
