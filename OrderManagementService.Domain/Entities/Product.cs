using OrderManagementService.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Domain.Entities
{
  public  class Product :  AuditableEntity
    {
        #region Properties

        
        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public bool IsActive { get; set; } = true;
        #endregion
        #region Navigation Properties
        public Inventory Inventory { get; set; } = null!;

        public ICollection<OrderItem> OrderItems { get; set; } = [];


        #endregion
    }
}
