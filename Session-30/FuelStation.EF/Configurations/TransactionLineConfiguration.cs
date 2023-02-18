using FuelStation.Model.Transactions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations
{
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.HasKey(transLine => transLine.ID);

            builder.Property(transLine => transLine.TransactionID);
            builder.Property(transLine => transLine.ItemID);
            builder.Property(transLine => transLine.Quantity);
            builder.Property(transLine => transLine.ItemPrice).HasPrecision(9, 2).IsRequired();
            builder.Property(transLine => transLine.NetValue).HasPrecision(9, 2).IsRequired();
            builder.Property(transLine => transLine.DiscountPercent).IsRequired();
            builder.Property(transLine => transLine.DiscountValue).HasPrecision(9, 2).IsRequired();
            builder.Property(transLine => transLine.TotalValue).HasPrecision(9, 2).IsRequired();

            builder.HasOne(transLine => transLine.Transaction)
                .WithMany(trans => trans.TransactionLines)
                .HasForeignKey(transLine => transLine.TransactionID)
                .IsRequired(true);
            builder.HasOne(transLine => transLine.Item)
                .WithMany(it => it.TransactionLines)
                .HasForeignKey(transLine => transLine.ItemID)
                .IsRequired(true);
        }
    }
}
