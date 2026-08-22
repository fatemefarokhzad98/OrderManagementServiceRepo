using OrderManagementService.Application.Common.Models;
using OrderManagementService.Application.Common.Results;
using OrderManagementService.Application.Contracts.Persistence;
using OrderManagementService.Application.Contracts.Services;
using OrderManagementService.Application.DTOs.Order.Requests;
using OrderManagementService.Application.DTOs.Order.Responses;
using OrderManagementService.Domain.Entities;
using OrderManagementService.Domain.Enums;

namespace OrderManagementService.Application.Services;

public sealed class OrderService(
    IBaseRepository<Order, long> orderRepository,
    IBaseRepository<Customer, long> customerRepository,
    IBaseRepository<Product, long> productRepository,
    IOrderRepository specializedOrderRepository,
    IInventoryService inventoryService,
    IUnitOfWork unitOfWork) : IOrderService
{
    private readonly IBaseRepository<Order, long> _orderRepository = orderRepository;
    private readonly IBaseRepository<Customer, long> _customerRepository = customerRepository;
    private readonly IBaseRepository<Product, long> _productRepository = productRepository;
    private readonly IOrderRepository _specializedOrderRepository = specializedOrderRepository;
    private readonly IInventoryService _inventoryService = inventoryService;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<OperationResult<long>> CreateAsync(CreateOrderRequest request, CancellationToken cancellationToken = default)
    {
        var buildResult = await BuildOrderAsync(request, cancellationToken);

        if (buildResult.IsFailure)
            return OperationResult<long>.Failure(buildResult.Error);
        var order = buildResult.Value!;
        await _orderRepository.AddAsync(order, cancellationToken);
        var commitResult = await _unitOfWork.CommitAsync(cancellationToken);

        if (commitResult.IsFailure)
            return OperationResult<long>.Failure(commitResult.Error);

        return OperationResult<long>.Success(order.Id);
    }

    public async Task<OperationResult<OrderDetailResponse>> GetByIdAsync(long orderId, CancellationToken cancellationToken = default)
    {
        var order = await _orderRepository.GetAsync(item => item.Id == orderId,
            item => new OrderDetailResponse
            {
                Id = item.Id,
                CustomerId = item.CustomerId,
                Status = item.Status,
                TotalAmount = item.TotalAmount,
                CreatedAt = item.CreatedAt,
                UpdatedAt = item.UpdatedAt,

                Items = item.OrderItems
                    .Select(orderItem => new OrderItemResponse
                    {
                        ProductId = orderItem.ProductId,
                        ProductName = orderItem.Product.Name,
                        Quantity = orderItem.Quantity,
                        UnitPrice = orderItem.UnitPrice,
                        TotalPrice = orderItem.TotalPrice
                    })
                    .ToList()
                    .AsReadOnly()
            }, cancellationToken);


        if (order is null)
            return OperationResult<OrderDetailResponse>.Failure(new Error("Order.NotFound", "سفارش پیدا نشد."));
        return OperationResult<OrderDetailResponse>.Success(order);
    }

    public Task<OperationResult<PagedResult<OrderResponse>>> SearchAsync(OrderSearchRequest request, CancellationToken cancellationToken = default)
    {
        if (request.PageNumber <= 0 || request.PageSize is <= 0 or > 100)
            return Task.FromResult(OperationResult<PagedResult<OrderResponse>>.Failure(new Error("Order.Pagination.Invalid", "اطلاعات صفحه‌بندی معتبر نیست.")));

        if (request.FromDate.HasValue && request.ToDate.HasValue && request.FromDate > request.ToDate)
            return Task.FromResult(OperationResult<PagedResult<OrderResponse>>.Failure(new Error("Order.DateRange.Invalid", "بازه زمانی معتبر نیست.")));

        var query = _orderRepository.GetAll(order => (!request.CustomerId.HasValue || order.CustomerId == request.CustomerId.Value) &&

            (!request.Status.HasValue || order.Status == request.Status.Value) &&

            (!request.FromDate.HasValue || order.CreatedAt >= request.FromDate.Value) &&

            (!request.ToDate.HasValue || order.CreatedAt <= request.ToDate.Value));

        var totalCount = query.Count();

        var orders = query
            .OrderByDescending(order => order.CreatedAt)
            .Skip((request.PageNumber - 1) * request.PageSize)
            .Take(request.PageSize)
            .Select(order => new OrderResponse
            {
                Id = order.Id,
                CustomerId = order.CustomerId,
                Status = order.Status,
                TotalAmount = order.TotalAmount,
                CreatedAt = order.CreatedAt
            })
            .ToList()
            .AsReadOnly();

        var page = new PagedResult<OrderResponse>
        {
            Items = orders,
            PageNumber = request.PageNumber,
            PageSize = request.PageSize,
            TotalCount = totalCount
        };
        return Task.FromResult(OperationResult<PagedResult<OrderResponse>>.Success(page));
    }

    public async Task<OperationResult> ChangeStatusAsync(long orderId, ChangeOrderStatusRequest request, CancellationToken cancellationToken = default)
    {
        var order = await _specializedOrderRepository.GetByIdWithItemsAsync(orderId, cancellationToken);
        if (order is null)
            return OperationResult.Failure(new Error("Order.NotFound", "سفارش پیدا نشد."));
        if (!order.CanChangeStatusTo(request.Status))
            return OperationResult.Failure(new Error("Order.Status.InvalidTransition", $"تغییر وضعیت از {order.Status} به {request.Status} مجاز نیست."));

        if (order.Status == OrderStatus.Pending && request.Status == OrderStatus.Confirmed)
        {
            var reserveResult = await _inventoryService.ReserveAsync(order.OrderItems
                .Select(item =>
                        new ReserveInventoryItem(
                            item.ProductId,
                            item.Quantity)), cancellationToken);
            if (reserveResult.IsFailure)
                return reserveResult;
        }
        order.ChangeStatus(request.Status);
        var commitResult = await _unitOfWork.CommitAsync(cancellationToken);
        return commitResult.IsFailure ? OperationResult.Failure(commitResult.Error) : OperationResult.Success();
    }

    public async Task<OperationResult> DeleteAsync(long orderId, CancellationToken cancellationToken = default)
    {
        var order = await _orderRepository.GetAsync(item => item.Id == orderId, cancellationToken);
        if (order is null)
            return OperationResult.Failure(new Error("Order.NotFound", "سفارش پیدا نشد."));
        _orderRepository.Remove(order);
        var commitResult = await _unitOfWork.CommitAsync(cancellationToken);
        return commitResult.IsFailure ? OperationResult.Failure(commitResult.Error) : OperationResult.Success();
    }

    public async Task<OperationResult> BulkInsertAsync(BulkCreateOrderRequest request, CancellationToken cancellationToken = default)
    {
        if (request.Orders.Count == 0)
            return OperationResult.Failure(new Error("Order.Bulk.Empty", "سفارشی برای ثبت ارسال نشده است."));
           var orders = new List<Order>();
        foreach (var requestItem in request.Orders)
        {
            var buildResult = await BuildOrderAsync(requestItem, cancellationToken);
            if (buildResult.IsFailure)
                return OperationResult.Failure(buildResult.Error);
            orders.Add(buildResult.Value!);
        }

        await _orderRepository.AddRangeAsync(orders, cancellationToken);

        var commitResult = await _unitOfWork.CommitAsync(cancellationToken);

        return commitResult.IsFailure ? OperationResult.Failure(commitResult.Error) : OperationResult.Success();
    }
    #region Private Method
    private async Task<OperationResult<Order>> BuildOrderAsync(CreateOrderRequest request, CancellationToken cancellationToken)
    {
        var customerExists = await _customerRepository.ExistAsync(customer => customer.Id == request.CustomerId, cancellationToken);
        if (!customerExists)
            return OperationResult<Order>.Failure(new Error("Order.Customer.NotFound", "مشتری پیدا نشد."));
        if (request.Items.Count == 0)
            return OperationResult<Order>.Failure(new Error("Order.Items.Empty", "سفارش باید حداقل یک محصول داشته باشد."));

        if (request.Items.Any(item => item.ProductId <= 0 || item.Quantity <= 0))
            return OperationResult<Order>.Failure(new Error("Order.Items.Invalid", "شناسه و تعداد محصول معتبر نیست."));

        var normalizedItems = request.Items
            .GroupBy(item => item.ProductId)
            .Select(group => new
            {
                ProductId = group.Key,
                Quantity = group.Sum(item =>
                    item.Quantity)
            })
            .ToArray();

        var productIds = normalizedItems
            .Select(item => item.ProductId)
            .ToArray();

        var products = _productRepository
            .GetAll(
                product => productIds.Contains(product.Id) && product.IsActive,
                product => new
                {
                    product.Id,
                    product.Price
                })
            .ToList();

        if (products.Count != productIds.Length)

            return OperationResult<Order>.Failure(new Error("Order.Product.NotFound", "یک یا چند محصول فعال پیدا نشد."));

        var orderItems = normalizedItems
            .Select(item =>
            {
                var product = products.Single(product => product.Id == item.ProductId);
                return new CreateOrderItem(ProductId: item.ProductId, Quantity: item.Quantity, UnitPrice: product.Price);
            })
            .ToArray();

        return OperationResult<Order>.Success(new Order(request.CustomerId, orderItems));
    }

    #endregion




}