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
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configuration()
        {

        }
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(cus => cus.ID);
            builder.Property(cus => cus.Code)
                    .HasMaxLength(3);
            builder.Property(cus => cus.Description)
                    .HasMaxLength(20);
            builder.HasOne(cus => cus.Transaction)
                    .WithOne(trans => trans.Customer)
                    .HasForeignKey<Transaction>(trans => trans.ID);
        }
    }
}
