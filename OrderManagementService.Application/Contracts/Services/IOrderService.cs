using OrderManagementService.Application.Common.Models;
using OrderManagementService.Application.Common.Results;
using OrderManagementService.Application.DTOs.Order.Requests;
using OrderManagementService.Application.DTOs.Order.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.Contracts.Services
{
    public interface IOrderService
    {
        Task<OperationResult<long>> CreateAsync(CreateOrderRequest request, CancellationToken cancellationToken = default);
        Task<OperationResult<OrderDetailResponse>> GetByIdAsync(long orderId, CancellationToken cancellationToken = default);
        Task<OperationResult<PagedResult<OrderResponse>>> SearchAsync(OrderSearchRequest request, CancellationToken cancellationToken = default);
        Task<OperationResult> ChangeStatusAsync(long orderId, ChangeOrderStatusRequest request, CancellationToken cancellationToken = default);
        Task<OperationResult> DeleteAsync(long orderId, CancellationToken cancellationToken = default);
        Task<OperationResult> BulkInsertAsync(BulkCreateOrderRequest request, CancellationToken cancellationToken = default);

    }
}
