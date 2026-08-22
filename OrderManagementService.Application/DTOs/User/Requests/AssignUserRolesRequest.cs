using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.DTOs.User.Requests
{
  public  class AssignUserRolesRequest
    {
        public IReadOnlyCollection<long> RoleIds { get; set; } = [];

    }
}
