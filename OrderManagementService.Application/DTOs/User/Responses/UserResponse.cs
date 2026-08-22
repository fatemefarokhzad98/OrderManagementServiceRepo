using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.DTOs.User.Responses
{
 public   class UserResponse
    {
        public long Id { get; set; }

        public string Username { get; set; } = null!;

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }

        public IReadOnlyCollection<string> Roles { get; set; } = [];
    }
}
