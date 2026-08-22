using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.DTOs.Product.Responses
{
    public class ProductResponse
    {
        public long Id { get; init; }

        public string Name { get; init; } = null!;

        public string? Description { get; init; }

        public decimal Price { get; init; }

        public int InventoryQuantity { get; init; }

        public bool IsActive { get; init; }

        public DateTime CreatedAt { get; init; }

        public DateTime? UpdatedAt { get; init; }
    }
}
