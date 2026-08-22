using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Domain.Common
{
    public interface IActivable
    {
        public bool IsActive { get;  } 
    }
}
