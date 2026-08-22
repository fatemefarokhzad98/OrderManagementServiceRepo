using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OrderManagementService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Infrastructure.Configs
{
    public class RefreshTokenConfigs : IEntityTypeConfiguration<RefreshToken>
    {
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder.HasKey(token => token.Id);

            builder.Property(token => token.TokenHash)
                .IsRequired()
                .HasMaxLength(64);

            builder.Property(token => token.ExpiresAt)
                .IsRequired();

            builder.Property(token => token.RevokedAt)
                .IsRequired(false);

            builder.HasIndex(token => token.TokenHash)
                .IsUnique();
            //  
            builder.HasIndex(token => new
            {
                token.UserId,
                token.ExpiresAt
            });

        }
    }
}
