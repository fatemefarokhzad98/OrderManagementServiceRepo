using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderManagementService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Infrastructure.Configs
{
    public class OrderItemConfigs : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable(x => x.HasCheckConstraint($"CK_{nameof(OrderItem)}_{nameof(OrderItem.Quantity)}", $"{nameof(OrderItem.Quantity)} >= 0"));
            builder.ToTable(x => x.HasCheckConstraint($"CK_{nameof(OrderItem)} _{nameof(OrderItem.UnitPrice)}", $"{nameof(OrderItem.UnitPrice)} >= 0"));
        }
    }
}
