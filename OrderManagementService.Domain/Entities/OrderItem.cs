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
        #region Properties
        public long OrderId { get; set; }

        public long ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal TotalPrice => Quantity * UnitPrice;
        public bool IsActive { get; set; }

        #endregion

        #region Navigation Properties
        public Order Order { get; set; } = null!;

        public Product Product { get; set; } = null!;
        #endregion

    }
}
