using OrderManagementService.Application.Common.Results;
using OrderManagementService.Application.DTOs.Product.Requests;
using OrderManagementService.Application.DTOs.Product.Responses;
using OrderManagementService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.Contracts.Services;
public interface IProductService
{

    Task<OperationResult<long>> CreateAsync(CreateProductRequest request, CancellationToken cancellationToken = default);
    Task<OperationResult<ProductResponse>> GetByIdAsync(long productId, CancellationToken cancellationToken = default);
    Task<OperationResult<IReadOnlyCollection<ProductResponse>>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<OperationResult> UpdateAsync(long productId, UpdateProductRequest request, CancellationToken cancellationToken = default);
    Task<OperationResult> ChangeStatusAsync(long productId, ChangeProductStatusRequest request, CancellationToken cancellationToken = default);
}


