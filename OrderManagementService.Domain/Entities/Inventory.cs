using OrderManagementService.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Domain.Entities
{
  public   class Inventory : AuditableEntity
    {
        #region Properties
        public long ProductId { get; set; }

        public int Quantity { get; set; }
        #endregion
        #region Navigation Property
        public Product Product { get; set; } = null!;
        #endregion
    }
}
