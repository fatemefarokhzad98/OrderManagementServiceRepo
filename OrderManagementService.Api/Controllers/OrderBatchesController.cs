using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrderManagementService.Api.Models.Requests;
using OrderManagementService.Application.Contracts.Services;
using OrderManagementService.Application.DTOs.Order.Requests;

namespace OrderManagementService.Api.Controllers;

[Authorize(Roles = "Admin")]
[ApiController]
[Route("api/v1/order-batches")]
public sealed class OrderBatchesController(
    IOrderService orderService) : ApiControllerBase
{
    private readonly IOrderService _orderService = orderService;

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] BulkCreateOrderRequestModel request, CancellationToken cancellationToken)
    {
        var serviceRequest =
            new BulkCreateOrderRequest
            {
                Orders = [.. request.Orders.Select(MapOrder)]
            };

        var result = await _orderService.BulkInsertAsync(serviceRequest, cancellationToken);

        return result.IsFailure ? Failure(result.Error) : StatusCode(StatusCodes.Status201Created);

    }

    private static CreateOrderRequest MapOrder(CreateOrderRequestModel request)

    {
        return new CreateOrderRequest
        {
            CustomerId = request.CustomerId,

            Items = [.. request.Items
                .Select(item =>
                    new CreateOrderItemRequest
                    {
                        ProductId = item.ProductId,
                        Quantity = item.Quantity
                    })]
        };
    }
}