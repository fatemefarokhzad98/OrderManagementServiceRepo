using OrderManagementService.Application.Common.Results;
using OrderManagementService.Application.Contracts.Persistence;
using OrderManagementService.Application.Contracts.Services;
using OrderManagementService.Application.DTOs.Product.Requests;
using OrderManagementService.Application.DTOs.Product.Responses;
using OrderManagementService.Domain.Entities;

namespace OrderManagementService.Application.Services;

public sealed class ProductService(
    IBaseRepository<Product, long> productRepository,
    IProductRepository specializedProductRepository,
    IUnitOfWork unitOfWork) : IProductService
{
    private readonly IBaseRepository<Product, long> _productRepository = productRepository;
    private readonly IProductRepository _specializedProductRepository = specializedProductRepository;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<OperationResult<long>> CreateAsync(CreateProductRequest request, CancellationToken cancellationToken = default)
    {
        var validationResult = Validate(request.Name, request.Description, request.Price, request.InitialQuantity);

        if (validationResult.IsFailure)
            return OperationResult<long>.Failure(validationResult.Error);

        var productName = request.Name.Trim();
        var duplicate = await _productRepository.ExistAsync(product => product.Name == productName, cancellationToken);
        if (duplicate)
            return OperationResult<long>.Failure(new Error("Product.Name.Duplicate", "محصولی با این نام قبلاً ثبت شده است."));

        var product = new Product(productName, request.Description, request.Price, request.InitialQuantity);

        await _productRepository.AddAsync(product, cancellationToken);

        var commitResult = await _unitOfWork.CommitAsync(cancellationToken);

        if (commitResult.IsFailure)
            return OperationResult<long>.Failure(commitResult.Error);
        return OperationResult<long>.Success(product.Id);
    }

    public async Task<OperationResult<ProductResponse>> GetByIdAsync(long productId, CancellationToken cancellationToken = default)
    {
        var product = await _productRepository.GetAsync(item => item.Id == productId,
            item => new ProductResponse
            {
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                Price = item.Price,
                InventoryQuantity = item.Inventory.Quantity,
                IsActive = item.IsActive,
                CreatedAt = item.CreatedAt,
                UpdatedAt = item.UpdatedAt
            }, cancellationToken);
        if (product is null)
        
            return OperationResult<ProductResponse>.Failure(new Error("Product.NotFound", "محصول پیدا نشد."));

        return OperationResult<ProductResponse>.Success(product);

    }

    public Task<OperationResult<IReadOnlyCollection<ProductResponse>>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        IReadOnlyCollection<ProductResponse> products = _productRepository
                .GetAll(
                    predicate: null,
                    item => new ProductResponse
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Description = item.Description,
                        Price = item.Price,
                        InventoryQuantity =
                            item.Inventory.Quantity,
                        IsActive = item.IsActive,
                        CreatedAt = item.CreatedAt,
                        UpdatedAt = item.UpdatedAt
                    })
                .OrderBy(item => item.Name)
                .ToList()
                .AsReadOnly();
        return Task.FromResult(OperationResult<IReadOnlyCollection<ProductResponse>>.Success(products));

    }

    public async Task<OperationResult> UpdateAsync(long productId, UpdateProductRequest request, CancellationToken cancellationToken = default)
    {
        var validationResult = Validate(request.Name, request.Description, request.Price, initialQuantity: 0);

        if (validationResult.IsFailure)
            return validationResult;

        var product = await _productRepository.GetAsync(item => item.Id == productId, cancellationToken);

        if (product is null)
            return OperationResult.Failure(new Error("Product.NotFound", "محصول پیدا نشد."));

        var productName = request.Name.Trim();

        var duplicate = await _productRepository.ExistAsync(item => item.Id != productId && item.Name == productName, cancellationToken);

        if (duplicate)
            return OperationResult.Failure(new Error("Product.Name.Duplicate", "نام محصول تکراری است."));

        product.ChangeInformation(productName, request.Description, request.Price);

        var commitResult = await _unitOfWork.CommitAsync(cancellationToken);

        return commitResult.IsFailure ? OperationResult.Failure(commitResult.Error) : OperationResult.Success();

    }

    public async Task<OperationResult> ChangeStatusAsync(long productId, ChangeProductStatusRequest request, CancellationToken cancellationToken = default)

    {
        var product = await _specializedProductRepository.GetByIdWithInventoryAsync(productId, cancellationToken);

        if (product is null)
            return OperationResult.Failure(new Error("Product.NotFound", "محصول پیدا نشد."));

        if (product.IsActive == request.IsActive)
            return OperationResult.Success();

        product.ChangeStatus(request.IsActive);

        var commitResult = await _unitOfWork.CommitAsync(cancellationToken);

        return commitResult.IsFailure ? OperationResult.Failure(commitResult.Error) : OperationResult.Success();


    }

    #region Private Method
    private static OperationResult Validate(string name, string? description, decimal price, int initialQuantity)
    {
        if (string.IsNullOrWhiteSpace(name))
            return OperationResult.Failure(new Error("Product.Name.Required", "نام محصول الزامی است."));

        if (name.Trim().Length > 100)
            return OperationResult.Failure(new Error("Product.Name.Invalid", "نام محصول حداکثر ۱۰۰ کاراکتر است."));

        if (description?.Trim().Length > 500)

            return OperationResult.Failure(new Error("Product.Description.Invalid", "توضیحات حداکثر ۵۰۰ کاراکتر است."));

        if (price < 0)

            return OperationResult.Failure(new Error("Product.Price.Invalid", "قیمت نمی‌تواند منفی باشد."));

        if (initialQuantity < 0)
            return OperationResult.Failure(new Error("Product.Inventory.Invalid", "موجودی اولیه نمی‌تواند منفی باشد."));

        return OperationResult.Success();
    }

    #endregion
}