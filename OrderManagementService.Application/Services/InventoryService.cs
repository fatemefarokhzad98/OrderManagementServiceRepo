using Microsoft.Extensions.Logging;
using OrderManagementService.Application.Common.Results;
using OrderManagementService.Application.Contracts.Persistence;
using OrderManagementService.Application.Contracts.Services;
using OrderManagementService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrderManagementService.Application.Services
{
    public class InventoryService(IBaseRepository<Inventory, long> inventoryRepo, ILogger<InventoryService> logger, IUnitOfWork unitOfWork) : IInventoryService
    {
        public async Task<OperationResult> IncreaseAsync(long productId, int quantity, CancellationToken cancellationToken = default)
        {
            if (productId <= 0)
                return OperationResult.Failure(new Error("Inventory.ProductId.Invalid", "شناسه محصول معتبر نیست."));

            if (quantity <= 0)
                return OperationResult.Failure(new Error("Inventory.Quantity.Invalid", "مقدار افزایش باید بیشتر از صفر باشد."));

            var inventory = await inventoryRepo.GetAsync(
                item =>
                    item.ProductId == productId &&
                    item.IsActive &&
                    item.Product.IsActive, cancellationToken);


            if (inventory is null)
                return OperationResult.Failure(new Error("Inventory.NotFound", "محصول یا موجودی فعال آن پیدا نشد."));

            inventory.Increase(quantity);
            var commitResult = await unitOfWork.CommitAsync(cancellationToken);
            return commitResult.IsFailure ? OperationResult.Failure(commitResult.Error) : OperationResult.Success();
        }

        public Task<OperationResult> ReserveAsync(IEnumerable<ReserveInventoryItem> items, CancellationToken cancellationToken = default)
        {
            if (items is null)
                return Task.FromResult(OperationResult.Failure(new Error("Inventory.Items.Empty", "محصولی برای رزرو ارسال نشده است.")));
            var requestedItems = items
                .GroupBy(item => item.ProductId)
                .Select(group => new ReserveInventoryItem(
                    ProductId: group.Key,
                    Quantity: group.Sum(item => item.Quantity)))
                .ToArray();
            if (requestedItems.Length == 0)
                return Task.FromResult(OperationResult.Failure(new Error("Inventory.Items.Empty", "محصولی برای رزرو ارسال نشده است.")));

            if (requestedItems.Any(item => item.ProductId <= 0 || item.Quantity <= 0))
                return Task.FromResult(OperationResult.Failure(new Error("Inventory.Items.Invalid", "شناسه محصول و تعداد باید معتبر باشند.")));

            var productIds = requestedItems
                .Select(item => item.ProductId)
                .ToArray();
            var inventories = inventoryRepo
                .GetAllTracked(inventory =>
                    productIds.Contains(inventory.ProductId) && inventory.IsActive && inventory.Product.IsActive)
                .ToList();

            if (inventories.Count != productIds.Length)
                return Task.FromResult(OperationResult.Failure(new Error("Inventory.NotFound", "یک یا چند محصول یا موجودی فعال پیدا نشد.")));
            foreach (var requestedItem in requestedItems)
            {
                var inventory = inventories.Single(item => item.ProductId == requestedItem.ProductId);
                if (inventory.Quantity < requestedItem.Quantity)
                {
                    return Task.FromResult(OperationResult.Failure(new Error("Inventory.Insufficient", $"موجودی محصول {requestedItem.ProductId} کافی نیست.")));

                }
            }
            foreach (var requestedItem in requestedItems)
            {
                var inventory = inventories.Single(item => item.ProductId == requestedItem.ProductId);
                inventory.Decrease(requestedItem.Quantity);

            }

            return Task.FromResult(OperationResult.Success());

        }
    }
}
