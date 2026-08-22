using OrderManagementService.Application.Common.Results;
using OrderManagementService.Application.Contracts.Persistence;
using OrderManagementService.Application.Contracts.Services;
using OrderManagementService.Application.DTOs.Role.Requests;
using OrderManagementService.Application.DTOs.Role.Responses;
using OrderManagementService.Domain.Entities;

namespace OrderManagementService.Application.Services;

public  class RoleService(IBaseRepository<Role, long> roleRepository, IUnitOfWork unitOfWork) : IRoleService
{
    private readonly IBaseRepository<Role, long> _roleRepository = roleRepository;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<OperationResult<long>> CreateAsync(CreateRoleRequest request, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(request.Name))
            return OperationResult<long>.Failure(new Error("Role.Name.Required", "نام نقش الزامی است."));

        var roleName = request.Name.Trim();
        var roleExists = await _roleRepository.ExistAsync(role => role.Name == roleName, cancellationToken);
        if (roleExists)
            return OperationResult<long>.Failure(new Error("Role.Name.Duplicate", "این نقش قبلاً ثبت شده است."));
        var role = new Role
        {
            Name = roleName
        };
        await _roleRepository.AddAsync(role, cancellationToken);
        var commitResult = await _unitOfWork.CommitAsync(cancellationToken);
        if (commitResult.IsFailure)
            return OperationResult<long>.Failure(commitResult.Error);
        return OperationResult<long>.Success(role.Id);
    }

    public Task<OperationResult<IReadOnlyCollection<RoleResponse>>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        IReadOnlyCollection<RoleResponse> roles = _roleRepository.GetAll(predicate: null,
                    role => new RoleResponse
                    {
                        Id = role.Id,
                        Name = role.Name,
                        IsActive = role.IsActive
                    })
                .OrderBy(role => role.Name)
                .ToList()
                .AsReadOnly();
        return Task.FromResult(OperationResult<IReadOnlyCollection<RoleResponse>>.Success(roles));
    }

    public async Task<OperationResult> ChangeStatusAsync(long roleId, ChangeRoleStatusRequest request, CancellationToken cancellationToken = default)
    {
        var role = await _roleRepository.GetAsync(role => role.Id == roleId, cancellationToken);
        if (role is null)
            return OperationResult.Failure(new Error("Role.NotFound", "نقش موردنظر پیدا نشد."));
        if (role.IsActive == request.IsActive)
            return OperationResult.Success();
        role.IsActive = request.IsActive;

        var commitResult = await _unitOfWork.CommitAsync(cancellationToken);

        return commitResult.IsFailure ? OperationResult.Failure(commitResult.Error) : OperationResult.Success();
    }


}