using CoffeeShop.Model;
using CoffeeShop.Orm.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Orm.Context
{
    public class AddDbContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<TransactionLine> TransactionLines { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new EmployeeConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new TransactionLineConfig());
            modelBuilder.ApplyConfiguration(new TransactionConfig());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connString = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True";
            optionsBuilder.UseSqlServer(connString);
        }
    }
}
