using Microsoft.EntityFrameworkCore;
using OrderManagementService.Domain.Common;
using OrderManagementService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Infrastructure.EfCore
{
    public class MainDbContext(DbContextOptions<MainDbContext> options) : DbContext(options)
    {
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MainDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
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
