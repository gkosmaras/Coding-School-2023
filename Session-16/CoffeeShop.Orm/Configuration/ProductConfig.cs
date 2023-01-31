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
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(prod => prod.ID);
            builder.Property(prod => prod.Code)
                    .HasMaxLength(10);
            builder.Property(prod => prod.Description)
                    .HasMaxLength(30);
            builder.Property(prod => prod.ProductCategoryID);
            builder.Property(prod => prod.TypeOfProduct);
            builder.Property(prod => prod.Price)
                    .HasColumnType("decimal(5,2)")
                    .HasPrecision(5, 2);
            builder.Property(prod => prod.Cost)
                    .HasColumnType("decimal(5,2)")
                    .HasPrecision(5, 2);
/*            builder.HasOne(prod => prod.ProductCategory)
                    .WithOne(prodCat => prodCat.Product)
                    .HasForeignKey<Product>(prod => prod.ID);*/
        }
    }
}
