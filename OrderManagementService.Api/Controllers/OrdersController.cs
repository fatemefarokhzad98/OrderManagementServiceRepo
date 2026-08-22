using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrderManagementService.Api.Models.Requests;
using OrderManagementService.Application.Common.Models;
using OrderManagementService.Application.Contracts.Services;
using OrderManagementService.Application.DTOs.Order.Requests;
using OrderManagementService.Application.DTOs.Order.Responses;

namespace OrderManagementService.Api.Controllers;

[Authorize]
[ApiController]
[Route("api/v1/orders")]
public  class OrdersController(IOrderService orderService) : ApiControllerBase
{
    private readonly IOrderService _orderService = orderService;

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Create([FromBody] CreateOrderRequestModel request, CancellationToken cancellationToken)
    {
        var serviceRequest = MapCreateRequest(request);

        var result = await _orderService.CreateAsync(serviceRequest, cancellationToken);

        if (result.IsFailure)
            return Failure(result.Error);

        var orderId = result.Value!;

        return CreatedAtAction(nameof(GetById), new { orderId }, new { id = orderId });

    }

    [HttpGet("{orderId:long}")]
    [ProducesResponseType(typeof(OrderDetailResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(long orderId, CancellationToken cancellationToken)
    {
        var result = await _orderService.GetByIdAsync(orderId, cancellationToken);

        return result.IsFailure ? Failure(result.Error) : Ok(result.Value);

    }

    [HttpGet]
    [ProducesResponseType(typeof(PagedResult<OrderResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Search([FromQuery] OrderSearchRequestModel request, CancellationToken cancellationToken)
    {
        var serviceRequest = new OrderSearchRequest
        {
            CustomerId = request.CustomerId,
            Status = request.Status,
            FromDate = request.FromDate,
            ToDate = request.ToDate,
            PageNumber = request.PageNumber,
            PageSize = request.PageSize
        };
        var result = await _orderService.SearchAsync(serviceRequest, cancellationToken);

        return result.IsFailure ? Failure(result.Error) : Ok(result.Value);
    }
   
    [HttpPatch("{orderId:long}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> ChangeStatus(long orderId, [FromBody] ChangeOrderStatusRequestModel request, CancellationToken cancellationToken)
    {
        var serviceRequest =
            new ChangeOrderStatusRequest
            {
                Status = request.Status
            };

        var result = await _orderService.ChangeStatusAsync(orderId, serviceRequest, cancellationToken);

        return result.IsFailure ? Failure(result.Error) : NoContent();

    }

    [Authorize(Roles = "Admin")]
    [HttpDelete("{orderId:long}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(long orderId, CancellationToken cancellationToken)
    {
        var result = await _orderService.DeleteAsync(orderId, cancellationToken);

        return result.IsFailure ? Failure(result.Error) : NoContent();

    }

    private static CreateOrderRequest MapCreateRequest(CreateOrderRequestModel request)
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