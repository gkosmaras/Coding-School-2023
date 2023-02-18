using FuelStation.Model.People;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer>builder)
        {
            builder.HasKey(cus => cus.ID);

            builder.Property(cus => cus.Name).HasMaxLength(50).IsRequired();
            builder.Property(cus => cus.Surname).HasMaxLength(50).IsRequired();
            builder.Property(cus => cus.CardNumber).HasMaxLength(50).IsRequired();
        }
    }
}
