using OrderManagementService.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Domain.Entities
{
    public class User : AuditableEntity
    {
        #region Properties
        public string Username { get; set; } = null!;

        public string PasswordHash { get; set; } = null!;

        public bool IsActive { get; set; } = true;
        #endregion

        #region Navigation Properties
        public ICollection<UserRole> UserRoles { get; set; } = [];

        #endregion



    }
}
