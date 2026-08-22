using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrderManagementService.Api.Models.Requests;
using OrderManagementService.Application.Contracts.Services;
using OrderManagementService.Application.DTOs.User.Requests;
using OrderManagementService.Application.DTOs.User.Responses;

namespace OrderManagementService.Api.Controllers;

[Authorize(Roles = "Admin")]
[ApiController]
[Route("api/v1/users")]
public  class UsersController(IUserService userService) : ApiControllerBase
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> Create([FromBody] CreateUserRequestModel request, CancellationToken cancellationToken)
    {
        var result = await userService.CreateAsync(
            new CreateUserRequest
            {
                Username = request.Username,
                Password = request.Password,
                RoleIds = request.RoleIds
            }, cancellationToken);

        if (result.IsFailure)
            return Failure(result.Error);

        var userId = result.Value!;
        return CreatedAtAction(nameof(GetById), new { userId }, new { id = userId });


    }

    [HttpGet("{userId:long}")]
    [ProducesResponseType(typeof(UserResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(long userId, CancellationToken cancellationToken)
    {
        var result = await userService.GetByIdAsync(userId, cancellationToken);

        return result.IsFailure ? Failure(result.Error) : Ok(result.Value);
    }

    [HttpPut("{userId:long}/roles")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> AssignRoles(long userId, [FromBody] AssignUserRolesRequestModel request, CancellationToken cancellationToken)
    {
        var result = await userService.AssignRolesAsync(userId,
            new AssignUserRolesRequest
            {
                RoleIds = request.RoleIds
            }, cancellationToken);

        return result.IsFailure ? Failure(result.Error) : NoContent();
    }

    [HttpPatch("{userId:long}/status")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ChangeStatus(long userId, [FromBody] ChangeUserStatusRequestModel request, CancellationToken cancellationToken)
    {
        var result = await userService.ChangeStatusAsync(userId,
            new ChangeUserStatusRequest
            {
                IsActive = request.IsActive
            }, cancellationToken);

        return result.IsFailure ? Failure(result.Error) : NoContent();

    }

  
    
}