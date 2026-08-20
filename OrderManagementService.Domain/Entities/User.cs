using OrderManagementService.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Domain.Entities
{
    public class User : BaseEntity<long>,IAuditableEntity
    {
        #region Properties
        public string Username { get; set; } = null!;

        public string PasswordHash { get; set; } = null!;

        public bool IsActive { get; set; } = true;
        public DateTime? UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        #endregion

        #region Navigation Properties
        public ICollection<Role> Roles { get; set; } = [];

        #endregion



    }
}
