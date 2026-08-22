using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.DTOs.Product.Requests
{
    public class CreateProductRequest
    {
        public string Name { get; init; } = null!;

        public string? Description { get; init; }

        public decimal Price { get; init; }

        public int InitialQuantity { get; init; }
    }
}
