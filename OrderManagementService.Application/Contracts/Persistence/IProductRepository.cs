using OrderManagementService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.Contracts.Persistence
{
   public interface IProductRepository
    {
        Task<Product?> GetByIdWithInventoryAsync(long productId, CancellationToken cancellationToken = default);
    }
}
