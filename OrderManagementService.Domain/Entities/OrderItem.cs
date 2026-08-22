using OrderManagementService.Domain.Common;

namespace OrderManagementService.Domain.Entities;

public sealed class OrderItem : BaseEntity<long>, IActivable
{
    private OrderItem()
    {
    }
    internal OrderItem(
        Order order,
        long productId,
        int quantity,
        decimal unitPrice)
    {
        ArgumentNullException.ThrowIfNull(order);

        if (productId <= 0)
            throw new ArgumentOutOfRangeException(nameof(productId), "شناسه محصول معتبر نیست.");

        if (quantity <= 0)
            throw new ArgumentOutOfRangeException(nameof(quantity), "تعداد محصول باید بیشتر از صفر باشد.");

        if (unitPrice < 0)
        
            throw new ArgumentOutOfRangeException(nameof(unitPrice), "قیمت محصول نمی‌تواند منفی باشد.");

        Order = order;
        ProductId = productId;
        Quantity = quantity;
        UnitPrice = unitPrice;
        IsActive = true;
    }

    public long OrderId { get; private set; }

    public long ProductId { get; private set; }

    public int Quantity { get; private set; }

    public decimal UnitPrice { get; private set; }

    public decimal TotalPrice =>
        Quantity * UnitPrice;

    public bool IsActive { get; set; }

    public Order Order { get; private set; } = null!;

    public Product Product { get; private set; } = null!;
}