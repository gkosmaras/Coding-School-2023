﻿using Microsoft.EntityFrameworkCore;
using PetShop.EF.Configurations;
using PetShop.Models;

namespace PetShop.EF.Context {

    public class PetShopDbContext : DbContext {

        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Pet> Pets { get; set; } = null!;
        public DbSet<PetFood> PetFoods { get; set; } = null!;
        public DbSet<Transaction> Transactions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new PetConfiguration());
            modelBuilder.ApplyConfiguration(new PetFoodConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());

            base.OnModelCreating(modelBuilder);

        }

/*        George Kosmaras DB Connection.*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=PetShop;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;" +
                "Encrypt=False;" +
                "TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;" +
                "MultiSubnetFailover=False"
                );

            base.OnConfiguring(optionsBuilder);

        }



        /* Ioannis Koukotzilas DB Connection */

/*        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

            optionsBuilder.UseSqlServer(
                "Data Source=localhost; " +
                "Initial Catalog=PetShop; " +
                "User ID=sa; " +
                "Password=uU904291$%!; " +
                "Integrated Security=False; " +
                "Connect Timeout=30; " +
                "Encrypt=False; " +
                "TrustServerCertificate=False; " +
                "ApplicationIntent=ReadWrite; " +
                "MultiSubnetFailover=False");

            base.OnConfiguring(optionsBuilder);

        }*/

    }

}
