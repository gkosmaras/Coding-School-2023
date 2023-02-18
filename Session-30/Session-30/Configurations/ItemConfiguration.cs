using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure (EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(it => it.ID);

            builder.Property(it => it.Code).IsRequired();
            builder.Property(it => it.Description).HasMaxLength(50).IsRequired();
            builder.Property(it => it.ItemType);
            builder.Property(it => it.Price).HasPrecision(9,2);
            builder.Property(it => it.Cost).HasPrecision(9, 2);
        }
    }
}
