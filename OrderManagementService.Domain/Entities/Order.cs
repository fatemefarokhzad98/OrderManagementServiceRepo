using OrderManagementService.Domain.Common;
using OrderManagementService.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Domain.Entities
{
    public class Order :BaseEntity<long>, IAuditableEntity
    {
        #region Properties
        public long CustomerId { get; set; }

        public OrderStatus Status { get; set; }

        public decimal TotalAmount => OrderItems.Sum(x => x.TotalPrice);
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        #endregion
        #region Navigation Properties
        public Customer Customer { get; set; } = null!;

        public ICollection<OrderItem> OrderItems { get; set; } = [];
     
        #endregion

    }
}
