using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrderManagementService.Api.Models.Requests;
using OrderManagementService.Application.Contracts.Services;
using OrderManagementService.Application.DTOs.Role.Requests;
using OrderManagementService.Application.DTOs.Role.Responses;

namespace OrderManagementService.Api.Controllers;

[Authorize(Roles = "Admin")]
[ApiController]
[Route("api/v1/roles")]
public sealed class RolesController(IRoleService roleService) : ApiControllerBase
{

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> Create([FromBody] CreateRoleRequestModel request, CancellationToken cancellationToken)
    {
        var result = await roleService.CreateAsync(
            new CreateRoleRequest
            {
                Name = request.Name
            }, cancellationToken);

        if (result.IsFailure)
            return Failure(result.Error);

        return StatusCode(StatusCodes.Status201Created, new { id = result.Value });
    }

    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyCollection<RoleResponse>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var result = await roleService.GetAllAsync(cancellationToken);

        return result.IsFailure ? Failure(result.Error) : Ok(result.Value);

    }

    [HttpPatch("{roleId:long}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ChangeStatus(long roleId, [FromBody] ChangeRoleStatusRequestModel request, CancellationToken cancellationToken)
    {
        var result = await roleService.ChangeStatusAsync(roleId,
            new ChangeRoleStatusRequest
            {
                IsActive = request.IsActive
            }, cancellationToken);

        return result.IsFailure ? Failure(result.Error) : NoContent();

    }
}