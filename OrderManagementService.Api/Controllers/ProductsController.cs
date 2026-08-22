using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrderManagementService.Api.Models.Requests;
using OrderManagementService.Application.Contracts.Services;
using OrderManagementService.Application.DTOs.Product.Requests;
using OrderManagementService.Application.DTOs.Product.Responses;

namespace OrderManagementService.Api.Controllers;

[Authorize]
[Route("api/v1/products")]
public sealed class ProductsController(IProductService productService) : ApiControllerBase
{
    [Authorize(Roles = "Admin")]
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> Create([FromBody] CreateProductRequestModel request, CancellationToken cancellationToken)
    {
        var result = await productService.CreateAsync(
            new CreateProductRequest
            {
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                InitialQuantity = request.InitialQuantity

            }, cancellationToken);

        if (result.IsFailure)
            return Failure(result.Error);

        return CreatedAtAction(nameof(GetById), new { productId = result.Value }, new { id = result.Value });
    }

    [HttpGet("{productId:long}")]
    [ProducesResponseType(typeof(ProductResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetById(long productId, CancellationToken cancellationToken)
    {
        var result = await productService.GetByIdAsync(productId, cancellationToken);

        return result.IsFailure ? Failure(result.Error) : Ok(result.Value);

    }

    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyCollection<ProductResponse>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var result = await productService.GetAllAsync(cancellationToken);

        return result.IsFailure ? Failure(result.Error) : Ok(result.Value);
    }

    [Authorize(Roles = "Admin")]
    [HttpPut("{productId:long}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> Update(long productId, [FromBody] UpdateProductRequestModel request, CancellationToken cancellationToken)
    {
        var result = await productService.UpdateAsync(productId,
            new UpdateProductRequest
            {
                Name = request.Name,
                Description = request.Description,
                Price = request.Price
            }, cancellationToken);

        return result.IsFailure ? Failure(result.Error) : NoContent();
    }

    [Authorize(Roles = "Admin")]
    [HttpPatch("{productId:long}/status")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> ChangeStatus(long productId, [FromBody] ChangeProductStatusRequestModel request, CancellationToken cancellationToken)
    {
        var result = await productService.ChangeStatusAsync(productId,

                new ChangeProductStatusRequest
                {
                    IsActive = request.IsActive
                }, cancellationToken);


        return result.IsFailure ? Failure(result.Error) : NoContent();

    }
}