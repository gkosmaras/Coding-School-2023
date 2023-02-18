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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure (EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(ee => ee.ID);

            builder.Property(ee => ee.Name).HasMaxLength(50).IsRequired();
            builder.Property(ee => ee.Surname).HasMaxLength(50).IsRequired();
            builder.Property(ee => ee.HireDateStart).IsRequired();
            builder.Property(ee => ee.HireDateEnd);
            builder.Property(ee => ee.SalaryPerMonth).HasPrecision(9, 2).IsRequired();
            builder.Property(ee => ee.EmployeeType).IsRequired();
        }
    }
}
