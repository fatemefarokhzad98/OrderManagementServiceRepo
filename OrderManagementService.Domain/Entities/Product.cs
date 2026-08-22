using OrderManagementService.Domain.Common;

namespace OrderManagementService.Domain.Entities;

public  class Product : BaseEntity<long>, IAuditableEntity,IActivable
{
    private Product()
    {
    }

    public Product(string name, string? description, decimal price, int initialQuantity)
    {
        ChangeInformation(name, description, price);

        Inventory = new Inventory(initialQuantity)
        {
            Product = this
        };
    }

    public string Name { get; private set; } = null!;

    public string? Description { get; private set; }

    public decimal Price { get; private set; }

    public bool IsActive { get; private set; } = true;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public Inventory Inventory { get; private set; } = null!;

    public ICollection<OrderItem> OrderItems { get; private set; } = [];

    public void ChangeInformation(string name, string? description, decimal price)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("نام محصول الزامی است.", nameof(name));
        if (name.Trim().Length > 100)
            throw new ArgumentException("نام محصول حداکثر ۱۰۰ کاراکتر است.", nameof(name));
        if (description?.Trim().Length > 500)
            throw new ArgumentException("توضیحات حداکثر ۵۰۰ کاراکتر است.", nameof(description));
        if(price < 0)
            throw new ArgumentOutOfRangeException(nameof(price));
        Name = name.Trim();
        Description = string.IsNullOrWhiteSpace(description) ? null : description.Trim();
        Price = price;
    }

        public void ChangeStatus(bool isActive)
        {
            IsActive = isActive;
            Inventory.IsActive = isActive;
        }
}