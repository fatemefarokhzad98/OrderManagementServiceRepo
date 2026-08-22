using Microsoft.EntityFrameworkCore;
using OrderManagementService.Domain.Common;
using OrderManagementService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Infrastructure.EfCore
{
    public sealed class MainDbContext(DbContextOptions<MainDbContext> options) : DbContext(options)
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MainDbContext).Assembly);

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (!typeof(IActivable).IsAssignableFrom(entityType.ClrType))

                   continue;
                
                var parameter = Expression.Parameter(entityType.ClrType, "entity");

                var isActiveProperty = Expression.Property(parameter, nameof(IActivable.IsActive));

                var filter = Expression.Lambda(isActiveProperty, parameter);
                modelBuilder.Entity(entityType.ClrType).HasQueryFilter(filter);

            }
            SeedData.Seed(modelBuilder);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ApplyAuditFields();

            return await base.SaveChangesAsync(cancellationToken);
        }
        private void ApplyAuditFields()
        {
            var addedEntries = ChangeTracker
                .Entries<IAuditableEntity>()
                .Where(x => x.State == EntityState.Added);

            foreach (var entry in addedEntries)
            {
                entry.Entity.CreatedAt = DateTime.Now;
            }
            
            var editedEntries = ChangeTracker
                .Entries<IAuditableEntity>()
                .Where(x => x.State == EntityState.Modified);

            foreach (var entry in editedEntries)
            {
                entry.Entity.UpdatedAt = DateTime.Now;
            }
        }
    }
}
