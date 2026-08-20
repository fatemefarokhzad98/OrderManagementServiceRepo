using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Domain.Entities
{
   public class UserRole
    {
        #region Properties
        public long UserId { get; set; }

        public long RoleId { get; set; }
        #endregion


        #region Navigation Properties
        public User User { get; set; } = null!;

        public Role Role { get; set; } = null!;

        #endregion


    }
}
