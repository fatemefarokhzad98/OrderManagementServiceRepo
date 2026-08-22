using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrderManagementService.Api.Models.Requests;
using OrderManagementService.Application.Contracts.Services;
using OrderManagementService.Application.DTOs.Customer.Requests;
using OrderManagementService.Application.DTOs.Customer.Responses;

namespace OrderManagementService.Api.Controllers;

[Authorize]
[ApiController]
[Route("api/v1/customers")]
public sealed class CustomersController(ICustomerService customerService) : ApiControllerBase
{

    [Authorize(Roles = "Admin")]
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> Create([FromBody] CreateCustomerRequestModel request, CancellationToken cancellationToken)
    {
        var result = await customerService.CreateAsync(
            new CreateCustomerRequest
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                PhoneNumber = request.PhoneNumber
            }, cancellationToken);

        if (result.IsFailure)
            return Failure(result.Error);

        var customerId = result.Value!;
        return CreatedAtAction(nameof(GetById), new { customerId }, new { id = customerId });

    }

    [HttpGet("{customerId:long}")]
    [ProducesResponseType(typeof(CustomerResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(long customerId, CancellationToken cancellationToken)
    {
        var result = await customerService.GetByIdAsync(customerId, cancellationToken);

        return result.IsFailure ? Failure(result.Error) : Ok(result.Value);
    }

    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyCollection<CustomerResponse>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var result = await customerService.GetAllAsync(cancellationToken);

        return result.IsFailure ? Failure(result.Error) : Ok(result.Value);
    }

    [Authorize(Roles = "Admin")]
    [HttpPut("{customerId:long}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status409Conflict)]

    public async Task<IActionResult> Update(long customerId, [FromBody] UpdateCustomerRequestModel request, CancellationToken cancellationToken)
    {
        var result = await customerService.UpdateAsync(customerId,
            new UpdateCustomerRequest
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                PhoneNumber = request.PhoneNumber
            }, cancellationToken);
        return result.IsFailure ? Failure(result.Error) : NoContent();


    }
}