using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeShop.Orm.Configuration
{
    public class ProductCatConfig : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("ProductCategory");
            builder.HasKey(prodCat => prodCat.ID);
            builder.Property(prodCat => prodCat.Code)
                .HasMaxLength(5);
            builder.Property(prodCat => prodCat.Description)
                .HasMaxLength(10);
            builder.Property(prodCat => prodCat.ProductType)
                .HasMaxLength(10);
/*            builder.HasOne(prodCat => prodCat.Product)
                    .WithOne(prod => prod.ProductCategory)
                    .HasForeignKey<Product>(prod => prod.ProductCategoryID);*/
        }
    }
}
