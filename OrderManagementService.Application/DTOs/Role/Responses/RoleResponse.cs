using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.DTOs.Role.Responses
{
  public  class RoleResponse
    {
        public long Id { get; set; }

        public string Name { get; set; } = null!;

        public bool IsActive { get; set ; }
    }
}
