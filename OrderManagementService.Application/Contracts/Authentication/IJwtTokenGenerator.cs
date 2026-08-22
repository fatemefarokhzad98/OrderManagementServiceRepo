using OrderManagementService.Application.Common.Results;
using OrderManagementService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.Contracts.Authentication
{
  public interface IJwtTokenGenerator
    {

        TokenResult GenerateTokens(User user);

        string HashRefreshToken(string refreshToken);
    }
}
