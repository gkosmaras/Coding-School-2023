using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShop.Models;

namespace PetShop.EF.Configurations {

    public class PetFoodConfiguration : IEntityTypeConfiguration<PetFood> {

        public void Configure(EntityTypeBuilder<PetFood> builder) {

            // Table Name
            builder.ToTable("PetFoods");

            // Primary Key
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(t => t.AnimalType).IsRequired();
            builder.Property(t => t.Price).HasPrecision(9, 2).IsRequired();
            builder.Property(t => t.Cost).HasPrecision(9, 2).IsRequired();

        }

    }

}
