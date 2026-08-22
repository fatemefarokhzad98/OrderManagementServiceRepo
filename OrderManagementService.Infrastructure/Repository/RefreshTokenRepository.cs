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
    public class RefreshTokenRepository(MainDbContext dbContext) : IRefreshTokenRepository
    {
        private readonly MainDbContext _dbContext = dbContext;

        public async Task AddAsync(RefreshToken refreshToken, CancellationToken cancellationToken = default)
        {
            await _dbContext.RefreshTokens.AddAsync(refreshToken, cancellationToken);
        }

        public async Task<RefreshToken?> GetByTokenHashAsync(string tokenHash, CancellationToken cancellationToken = default)
        {
            return await _dbContext.RefreshTokens
                .FirstOrDefaultAsync(x => x.TokenHash == tokenHash, cancellationToken);
        }

        public async Task<RefreshToken?> GetByTokenHashWithUserAndRolesAsync(string tokenHash, CancellationToken cancellationToken = default)
        {
            return await _dbContext.RefreshTokens
                .Include(x => x.User)
                .ThenInclude(x => x.Roles)
                .FirstOrDefaultAsync(x => x.TokenHash == tokenHash, cancellationToken);
        }
    }
}
