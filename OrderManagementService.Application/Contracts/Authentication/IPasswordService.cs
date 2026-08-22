using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.Contracts.Authentication
{
   public interface IPasswordService
    {
        string Hash(string password);

        bool Verify(string passwordHash, string password);


    }
}
