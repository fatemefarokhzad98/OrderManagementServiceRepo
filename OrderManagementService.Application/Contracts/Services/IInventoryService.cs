using OrderManagementService.Application.Common.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.Contracts.Services
{
    public record ReserveInventoryItem(long ProductId, int Quantity);
    public interface IInventoryService
    {
        Task<OperationResult> IncreaseAsync(long productId, int quantity, CancellationToken cancellationToken = default);
        Task<OperationResult> ReserveAsync(IEnumerable<ReserveInventoryItem> items, CancellationToken cancellationToken = default);
    }
}
