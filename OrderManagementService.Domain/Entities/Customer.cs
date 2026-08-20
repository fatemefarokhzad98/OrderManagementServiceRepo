using OrderManagementService.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Domain.Entities
{
   public class Customer : AuditableEntity
    {
        #region Properties
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? Email { get; set; }

        public string PhoneNumber { get; set; } = null!;

        public bool IsActive { get; set; } = true;
        #endregion


        #region Navigation Properties
        public ICollection<Order> Orders { get; set; } = [];

        #endregion


    }
}
