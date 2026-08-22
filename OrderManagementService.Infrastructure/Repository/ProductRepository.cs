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
   public class ProductRepository(MainDbContext dbContext) : IProductRepository
    {
        private readonly MainDbContext _dbContext = dbContext;

        public Task<Product?> GetByIdWithInventoryAsync(long productId, CancellationToken cancellationToken = default)
        {
            return _dbContext.Products
                .Include(product => product.Inventory)
                .SingleOrDefaultAsync(product => product.Id == productId, cancellationToken);
        }
    }
}
