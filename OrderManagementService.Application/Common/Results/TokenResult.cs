using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.Common.Results
{
    public class TokenResult
    {
        public string AccessToken { get; init; } = null!;

        public DateTime AccessTokenExpiresAt { get; init; }

        public string RefreshToken { get; init; } = null!;

        public DateTime RefreshTokenExpiresAt { get; init; }
    }
}
