using OrderManagementService.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Domain.Entities
{
  public  class Role:BaseEntity
    {
        public string Name { get; set; } = null!; 

        #region Navigation Properties
        public ICollection<UserRole> UserRoles { get; set; } = [];

        #endregion

    }
}
