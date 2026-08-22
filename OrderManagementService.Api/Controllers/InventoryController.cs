using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrderManagementService.Api.Models.Requests;
using OrderManagementService.Application.Contracts.Services;

namespace OrderManagementService.Api.Controllers;

[Authorize(Roles = "Admin")]
[Route("api/v1/products/{productId:long}/increase")]
public sealed class InventoryController(IInventoryService inventoryService) : ApiControllerBase
{
    [HttpPatch("increase")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> Increase(long productId, [FromBody] IncreaseInventoryRequestModel request, CancellationToken cancellationToken)
    {
        var result = await inventoryService.IncreaseAsync(productId, request.Quantity, cancellationToken);

        return result.IsFailure ? Failure(result.Error) : NoContent();


    }
}