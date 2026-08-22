using Microsoft.EntityFrameworkCore;
using OrderManagementService.Domain.Entities;
using OrderManagementService.Domain.Enums;

namespace OrderManagementService.Infrastructure.EfCore;

internal static class SeedData
{
    internal const string AdminUsername = "admin";
    internal const string AdminPassword = "Admin@123";
    internal const string UserUsername = "testuser";
    internal const string UserPassword = "User@1234";

    private const string AdminPasswordHash =
        "AQAAAAIAAYagAAAAEMNRuOXkXfvGqBVGIP8IO/rJ7a+14WbIWpedabZCj6IhcPFGsSbnRssT38ebMpVomA==";

    private const string UserPasswordHash =
        "AQAAAAIAAYagAAAAEPRd88RKLoyAe6Srmd6mjlwlY6RJfTbB1Kh5lpRPqbnjsos3L/xxeQVc3AY84rKZbQ==";

    private static readonly DateTime SeedDate =
        new(2026, 1, 1, 8, 0, 0, DateTimeKind.Utc);

    internal static void Seed(ModelBuilder modelBuilder)
    {
        SeedRolesAndUsers(modelBuilder);

        var customers = CreateCustomers();
        var orders = CreateOrders(out var orderItems, out var reservedQuantities);
        var products = CreateProducts();
        var inventories = CreateInventories(reservedQuantities);

        modelBuilder.Entity(typeof(Customer)).HasData(customers);
        modelBuilder.Entity(typeof(Product)).HasData(products);
        modelBuilder.Entity(typeof(Inventory)).HasData(inventories);
        modelBuilder.Entity(typeof(Order)).HasData(orders);
        modelBuilder.Entity(typeof(OrderItem)).HasData(orderItems);
    }

    private static void SeedRolesAndUsers(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity(typeof(Role)).HasData(
            new
            {
                Id = 1L,
                Name = "Admin",
                IsActive = true
            },
            new
            {
                Id = 2L,
                Name = "User",
                IsActive = true
            });

        modelBuilder.Entity(typeof(User)).HasData(
            new
            {
                Id = 1L,
                Username = AdminUsername,
                PasswordHash = AdminPasswordHash,
                IsActive = true,
                CreatedAt = SeedDate,
                UpdatedAt = (DateTime?)null
            },
            new
            {
                Id = 2L,
                Username = UserUsername,
                PasswordHash = UserPasswordHash,
                IsActive = true,
                CreatedAt = SeedDate,
                UpdatedAt = (DateTime?)null
            });

        modelBuilder.Entity("RoleUser").HasData(
            new
            {
                RolesId = 1L,
                UsersId = 1L
            },
            new
            {
                RolesId = 2L,
                UsersId = 2L
            });
    }

    private static object[] CreateCustomers()
    {
        return Enumerable.Range(1, 50)
            .Select(index => (object)new
            {
                Id = (long)index,
                FirstName = $"Customer{index:00}",
                LastName = $"Test{index:00}",
                PhoneNumber = $"0912{index:0000000}",
                CreatedAt = SeedDate.AddMinutes(index),
                UpdatedAt = (DateTime?)null
            })
            .ToArray();
    }

    private static object[] CreateProducts()
    {
        return Enumerable.Range(1, 200)
            .Select(index => (object)new
            {
                Id = (long)index,
                Name = $"Product {index:000}",
                Description = $"Seeded product number {index:000}",
                Price = GetProductPrice(index),
                IsActive = true,
                CreatedAt = SeedDate.AddMinutes(index),
                UpdatedAt = (DateTime?)null
            })
            .ToArray();
    }

    private static object[] CreateInventories(
        IReadOnlyDictionary<long, int> reservedQuantities)
    {
        return Enumerable.Range(1, 200)
            .Select(index =>
            {
                var productId = (long)index;
                var reserved = reservedQuantities.GetValueOrDefault(productId);

                return (object)new
                {
                    Id = productId,
                    ProductId = productId,
                    Quantity = 500 - reserved,
                    IsActive = true,
                    CreatedAt = SeedDate.AddMinutes(index),
                    UpdatedAt = (DateTime?)null
                };
            })
            .ToArray();
    }

    private static object[] CreateOrders(
        out object[] orderItems,
        out IReadOnlyDictionary<long, int> reservedQuantities)
    {
        var orders = new List<object>(20);
        var items = new List<object>();
        var reservedByProduct = new Dictionary<long, int>();
        long orderItemId = 1;

        for (var orderNumber = 1; orderNumber <= 20; orderNumber++)
        {
            var status = (OrderStatus)(((orderNumber - 1) % 4) + 1);
            var createdAt = SeedDate.AddDays(orderNumber);

            orders.Add(new
            {
                Id = (long)orderNumber,
                CustomerId = (long)orderNumber,
                Status = status,
                CreatedAt = createdAt,
                UpdatedAt = status == OrderStatus.Pending
                    ? (DateTime?)null
                    : createdAt.AddHours((int)status - 1)
            });

            var itemCount = 2 + (orderNumber % 4);

            for (var itemNumber = 1; itemNumber <= itemCount; itemNumber++)
            {
                var productId =
                    (long)((((orderNumber - 1) * 9) + (itemNumber * 17)) % 200 + 1);
                var quantity = 1 + ((orderNumber + itemNumber) % 5);

                items.Add(new
                {
                    Id = orderItemId++,
                    OrderId = (long)orderNumber,
                    ProductId = productId,
                    Quantity = quantity,
                    UnitPrice = GetProductPrice(productId),
                    IsActive = true
                });

                if (status != OrderStatus.Pending)
                {
                    reservedByProduct[productId] =
                        reservedByProduct.GetValueOrDefault(productId) + quantity;
                }
            }
        }

        orderItems = items.ToArray();
        reservedQuantities = reservedByProduct;
        return orders.ToArray();
    }

    private static decimal GetProductPrice(long productId)
    {
        return 100_000m + (productId * 25_000m);
    }
}
