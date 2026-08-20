using OrderManagementService.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Domain.Entities
{
    public class Role : BaseEntity<long>, IActivable
    {
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }

        #region Navigation Properties
        public ICollection<User> Users { get; set; } = [];

        #endregion

    }
}
