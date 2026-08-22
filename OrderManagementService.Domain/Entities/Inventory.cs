using OrderManagementService.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Domain.Entities
{
    public  class Inventory : BaseEntity<long>, IAuditableEntity, IActivable
    {
        private Inventory()
        {
        }

        public Inventory(int initialQuantity)
        {
            if (initialQuantity < 0)
            
                throw new ArgumentOutOfRangeException(nameof(initialQuantity), "موجودی اولیه نمی‌تواند منفی باشد.");

            Quantity = initialQuantity;
        }

        public long ProductId { get; private set; }

        public int Quantity { get; private set; }

        public bool IsActive { get;  set; } = true;

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public Product Product { get; set; } = null!;

        public void Increase(int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentOutOfRangeException(nameof(quantity), "مقدار افزایش باید بیشتر از صفر باشد.");

            Quantity += quantity;
        }

        public void Decrease(int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentOutOfRangeException(nameof(quantity), "مقدار کاهش باید بیشتر از صفر باشد.");

            if (Quantity < quantity)
                throw new InvalidOperationException("موجودی محصول کافی نیست.");
            Quantity -= quantity;
        }
    }
}
