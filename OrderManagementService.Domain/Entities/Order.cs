using OrderManagementService.Domain.Common;
using OrderManagementService.Domain.Enums;

namespace OrderManagementService.Domain.Entities;

public sealed record CreateOrderItem(
    long ProductId,
    int Quantity,
    decimal UnitPrice);

public class Order : BaseEntity<long>, IAuditableEntity
{
    private readonly List<OrderItem> _items = [];

    private Order()
    {
    }

    public Order(long customerId, IEnumerable<CreateOrderItem> items)
    {
        if(customerId <= 0)
            throw new ArgumentOutOfRangeException(nameof(customerId));
        var orderItems = items?.ToArray() ?? [];
        if (orderItems.Length == 0)
        {
            throw new ArgumentException("سفارش باید حداقل یک محصول داشته باشد.", nameof(items));
        }
        CustomerId = customerId;
        Status = OrderStatus.Pending;
        foreach (var item in orderItems)
        {
            _items.Add(new OrderItem(this,item.ProductId, item.Quantity, item.UnitPrice));
        }
    }

    public long CustomerId { get; private set; }

    public OrderStatus Status { get; private set; }

    public decimal TotalAmount =>
        _items.Sum(item => item.TotalPrice);

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public Customer Customer { get; private set; } = null!;

    public IReadOnlyCollection<OrderItem> OrderItems =>
        _items.AsReadOnly();

    public bool CanChangeStatusTo(OrderStatus newStatus)
    {
        return (int)newStatus == (int)Status + 1;
    }

    public void ChangeStatus(OrderStatus newStatus)
    {
        if (!CanChangeStatusTo(newStatus))
        {
            throw new InvalidOperationException(
                $"تغییر وضعیت از {Status} به {newStatus} مجاز نیست.");
        }

        Status = newStatus;
    }
}