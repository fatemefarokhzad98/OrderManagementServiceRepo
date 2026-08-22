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
 public class OrderRepository(MainDbContext dbContext) : IOrderRepository
    {
        private readonly MainDbContext _dbContext = dbContext;

        public Task<Order?> GetByIdWithItemsAsync(long orderId, CancellationToken cancellationToken = default)
        {
            return _dbContext.Order
                .Include(order => order.OrderItems)
                .SingleOrDefaultAsync(order => order.Id == orderId, cancellationToken);
        }
    }
}
