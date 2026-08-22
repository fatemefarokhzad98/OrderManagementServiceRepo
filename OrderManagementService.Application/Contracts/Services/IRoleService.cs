using OrderManagementService.Application.Common.Results;
using OrderManagementService.Application.DTOs.Role.Requests;
using OrderManagementService.Application.DTOs.Role.Responses;

namespace OrderManagementService.Application.Contracts.Services;

public interface IRoleService
{
    Task<OperationResult<long>> CreateAsync(CreateRoleRequest request, CancellationToken cancellationToken = default);
    Task<OperationResult<IReadOnlyCollection<RoleResponse>>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<OperationResult> ChangeStatusAsync(long roleId, ChangeRoleStatusRequest request, CancellationToken cancellationToken = default);



}