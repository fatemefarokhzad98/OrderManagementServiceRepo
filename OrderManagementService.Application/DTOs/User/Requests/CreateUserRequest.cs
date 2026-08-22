using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.DTOs.User.Requests
{
  public  class CreateUserRequest
    {
        public string Username { get; set; } = null!;

        public string Password { get; set; } = null!;

        public IReadOnlyCollection<long> RoleIds { get; set; } = [];
    }
}
