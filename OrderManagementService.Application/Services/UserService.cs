using OrderManagementService.Application.Common.Results;
using OrderManagementService.Application.Contracts.Authentication;
using OrderManagementService.Application.Contracts.Persistence;
using OrderManagementService.Application.Contracts.Services;
using OrderManagementService.Application.DTOs.User.Requests;
using OrderManagementService.Application.DTOs.User.Responses;
using OrderManagementService.Domain.Entities;

namespace OrderManagementService.Application.Services;

public sealed class UserService(
    IBaseRepository<User, long> userRepository,
    IBaseRepository<Role, long> roleRepository,
    IUserRepository specializedUserRepository,
    IPasswordService passwordService,
    IUnitOfWork unitOfWork) : IUserService
{
    private readonly IBaseRepository<User, long> _userRepository = userRepository;
    private readonly IBaseRepository<Role, long> _roleRepository = roleRepository;
    private readonly IUserRepository _specializedUserRepository = specializedUserRepository;
    private readonly IPasswordService _passwordService = passwordService;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<OperationResult<long>> CreateAsync(CreateUserRequest request, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(request.Username))
        {
            return OperationResult<long>.Failure(new Error("User.Username.Required", "نام کاربری الزامی است."));
        }

        if (string.IsNullOrWhiteSpace(request.Password) || request.Password.Length < 8)
            return OperationResult<long>.Failure(new Error("User.Password.Invalid", "رمز عبور باید حداقل ۸ کاراکتر باشد."));
        var username = request.Username.Trim();
        var usernameExists = await _userRepository.ExistAsync(user => user.Username == username, cancellationToken);
        if (usernameExists)
            return OperationResult<long>.Failure(new Error("User.Username.Duplicate", "این نام کاربری قبلاً ثبت شده است."));

        var roleResult = await LoadRolesAsync(request.RoleIds, cancellationToken);
        if (roleResult.IsFailure)
            return OperationResult<long>.Failure(roleResult.Error);
        var user = new User
        {
            Username = username,
            PasswordHash = _passwordService.Hash(request.Password),
            IsActive = true
        };

        foreach (var role in roleResult.Value!)
            user.Roles.Add(role);

        await _userRepository.AddAsync(user, cancellationToken);
        var commitResult = await _unitOfWork.CommitAsync(cancellationToken);
        if (commitResult.IsFailure)
            return OperationResult<long>.Failure(commitResult.Error);
        return OperationResult<long>.Success(user.Id);
    }

    public async Task<OperationResult<UserResponse>> GetByIdAsync(long userId, CancellationToken cancellationToken = default)
    {
        var user = await _userRepository.GetAsync(user => user.Id == userId,
            user => new UserResponse
            {
                Id = user.Id,
                Username = user.Username,
                IsActive = user.IsActive,
                CreatedAt = user.CreatedAt,
                Roles = user.Roles
                    .Select(role => role.Name)
                    .ToList()
                    .AsReadOnly()
            }, cancellationToken);

        if (user is null)
            return OperationResult<UserResponse>.Failure(new Error("User.NotFound", "کاربر موردنظر پیدا نشد."));
        return OperationResult<UserResponse>.Success(user);
    }

    public async Task<OperationResult> AssignRolesAsync(long userId, AssignUserRolesRequest request, CancellationToken cancellationToken = default)
    {
        var user = await _specializedUserRepository.GetByIdWithRolesAsync(userId, cancellationToken);
        if (user is null)
            return OperationResult.Failure(new Error("User.NotFound", "کاربر موردنظر پیدا نشد."));
        var roleResult = await LoadRolesAsync(request.RoleIds, cancellationToken);

        if (roleResult.IsFailure)
            return OperationResult.Failure(roleResult.Error);

        var roles = roleResult.Value!;
        var currentRoleIds = user.Roles
            .Select(role => role.Id)
            .OrderBy(id => id)
            .ToArray();

        var requestedRoleIds = roles
            .Select(role => role.Id)
            .OrderBy(id => id)
            .ToArray();

        if (currentRoleIds.SequenceEqual(requestedRoleIds))
            return OperationResult.Success();
        user.Roles.Clear();
        foreach (var role in roles)
            user.Roles.Add(role);
        var commitResult = await _unitOfWork.CommitAsync(cancellationToken);
        return commitResult.IsFailure ? OperationResult.Failure(commitResult.Error) : OperationResult.Success();

    }

    public async Task<OperationResult> ChangeStatusAsync(long userId, ChangeUserStatusRequest request, CancellationToken cancellationToken = default)
    {
        var user = await _userRepository.GetAsync(user => user.Id == userId, cancellationToken);
        if (user is null)
            return OperationResult.Failure(new Error("User.NotFound", "کاربر موردنظر پیدا نشد."));

        if (user.IsActive == request.IsActive)
            return OperationResult.Success();

        user.IsActive = request.IsActive;
        var commitResult = await _unitOfWork.CommitAsync(cancellationToken);
        return commitResult.IsFailure ? OperationResult.Failure(commitResult.Error) : OperationResult.Success();
    }

    #region Private Method

    #endregion
    private async Task<OperationResult<IReadOnlyCollection<Role>>> LoadRolesAsync(IEnumerable<long> requestedRoleIds, CancellationToken cancellationToken)
    {
        var roleIds = requestedRoleIds
            .Distinct()
            .ToArray();
        if (roleIds.Length == 0)
            return OperationResult<IReadOnlyCollection<Role>>.Failure(new Error("User.Roles.Required", "حداقل یک نقش باید برای کاربر انتخاب شود."));

        var roles = new List<Role>();
        foreach (var roleId in roleIds)
        {
            var role = await _roleRepository.GetAsync(
                role =>
                    role.Id == roleId &&
                    role.IsActive, cancellationToken);
            if (role is null)
            
                return OperationResult<IReadOnlyCollection<Role>>.Failure(new Error("User.Role.NotFound", $"نقش فعال با شناسه {roleId} پیدا نشد."));

            roles.Add(role);
        }
        return OperationResult<IReadOnlyCollection<Role>>.Success(roles.AsReadOnly());

    }
}