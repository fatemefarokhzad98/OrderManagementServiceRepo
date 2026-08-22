using OrderManagementService.Application.Common.Results;
using OrderManagementService.Application.DTOs.User.Requests;
using OrderManagementService.Application.DTOs.User.Responses;

namespace OrderManagementService.Application.Contracts.Services;

public interface IUserService
{
    Task<OperationResult<long>> CreateAsync(CreateUserRequest request, CancellationToken cancellationToken = default);
    Task<OperationResult<UserResponse>> GetByIdAsync(long userId, CancellationToken cancellationToken = default);
    Task<OperationResult> AssignRolesAsync(long userId, AssignUserRolesRequest request, CancellationToken cancellationToken = default);
    Task<OperationResult> ChangeStatusAsync(long userId, ChangeUserStatusRequest request, CancellationToken cancellationToken = default);
}