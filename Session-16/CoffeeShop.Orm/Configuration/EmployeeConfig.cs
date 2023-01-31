using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Orm.Configuration
{
    public class EmployeeConfig: IEntityTypeConfiguration<Employee>
    {
        public void Configuration()
        {

        }

        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(ee => ee.ID);
            builder.Property(ee => ee.Name)
                    .HasMaxLength(30);
            builder.Property(ee => ee.Surname)
                    .HasMaxLength(30);
            builder.Property(ee => ee.TypeOfEmployee)
                    .HasMaxLength(10);
            builder.Property(ee => ee.SalaryPerMonth)
                    .HasColumnType("decimal(5,2)")
                    .HasPrecision(5, 2);
            builder.HasOne(ee => ee.Transaction)
                    .WithOne(trans => trans.Employee)
                    .HasForeignKey<Transaction>(trans => trans.ID);
        }
    }
}
