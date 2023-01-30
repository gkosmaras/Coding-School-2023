using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeShop.Orm.Configuration
{
    public class TransactionConfig : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactions");
            builder.HasKey(trans => trans.ID);
            builder.Property(trans => trans.Date);
            builder.Property(trans => trans.CustomerID);
            builder.Property(trans => trans.EmployeeID);
            builder.Property(trans => trans.TypeOfPayment);
            builder.Property(trans => trans.Cost);
            builder.Property(trans => trans.TotalPrice);
        }
    }
}
