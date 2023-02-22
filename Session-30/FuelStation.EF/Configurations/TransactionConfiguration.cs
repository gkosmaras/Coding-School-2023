using FuelStation.Model.Transactions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(trans => trans.ID);
            builder.Property(trans => trans.ID).ValueGeneratedOnAdd();

            builder.Property(trans => trans.Date);
            builder.Property(trans => trans.EmployeeID);
            builder.Property(trans => trans.CustomerID);
            builder.Property(trans => trans.TotalValue).HasPrecision(10, 2);
            builder.Property(trans => trans.PaymentMethod);

            builder.HasOne(trans => trans.Employee)
                .WithMany(ee => ee.Transactions)
                .HasForeignKey(trans => trans.EmployeeID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(trans => trans.Customer)
                .WithMany(cus => cus.Transactions)
                .HasForeignKey(trans => trans.CustomerID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
