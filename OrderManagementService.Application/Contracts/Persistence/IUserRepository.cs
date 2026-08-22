using OrderManagementService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.Contracts.Persistence
{
    public interface IUserRepository
    {
        Task<User?> GetByUsernameWithRolesAsync(string username, CancellationToken cancellationToken = default);
        Task<User?> GetByIdWithRolesAsync(long userId, CancellationToken cancellationToken = default);


    }
}
