using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.DTOs.Authentication.Requests
{
    public class LoginRequest
    {
        public string Username { get; init; } = null!;

        public string Password { get; init; } = null!;
    }
}
