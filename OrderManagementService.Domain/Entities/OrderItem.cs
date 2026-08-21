using OrderManagementService.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Domain.Entities
{
   public class OrderItem:BaseEntity<long>,IActivable
    {
        private OrderItem() {  }
        internal OrderItem(long orderId,
            long productId,
            int quantity,
            decimal unitPrice)
        {
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
        #region Properties
        public long OrderId { get; private set; }

        public long ProductId { get; private set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; private set; }

        public decimal TotalPrice => Quantity * UnitPrice;
        public bool IsActive { get; set; }

        #endregion

        #region Navigation Properties
        public Order Order { get; set; } = null!;

        public Product Product { get; set; } = null!;
        #endregion

    }
}
