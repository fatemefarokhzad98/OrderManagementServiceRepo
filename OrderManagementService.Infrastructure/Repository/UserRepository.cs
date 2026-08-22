using Microsoft.EntityFrameworkCore;
using OrderManagementService.Application.Contracts.Persistence;
using OrderManagementService.Domain.Entities;
using OrderManagementService.Infrastructure.EfCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Infrastructure.Repository
{
  public  class UserRepository(MainDbContext dbContext) : IUserRepository
    {
        private readonly MainDbContext _dbContext = dbContext;

        public Task<User?> GetByUsernameWithRolesAsync(string username, CancellationToken cancellationToken = default)
        {
            return _dbContext.Users
                .AsNoTracking()
                .Include(user => user.Roles)
                .SingleOrDefaultAsync(
                    user => user.Username == username, cancellationToken);

        }
        public Task<User?> GetByIdWithRolesAsync(long userId, CancellationToken cancellationToken = default)
        {
            return _dbContext.Users
                .Include(user => user.Roles)
                .SingleOrDefaultAsync(user => user.Id == userId, cancellationToken);

        }
    }
}
