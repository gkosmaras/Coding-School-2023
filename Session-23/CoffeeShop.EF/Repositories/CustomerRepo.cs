using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using CoffeeShop.EF.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.EF.Repositories
{
    public class CustomerRepo : IEntityRepo<Customer>
    {
        public void Create(Customer customer)
        {
            using var context = new CoffeeShopDbContext();
            if (customer.Id != 0)
            {
                throw new ArgumentException("Given customer should not have an ID set", nameof(customer));
            }
            context.Customers.Add(customer);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            using var context = new CoffeeShopDbContext();
            var fCustomer = context.Customers.SingleOrDefault(customer => customer.Id == id);
            if (fCustomer is null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            context.Customers.Remove(fCustomer);
            context.SaveChanges();
        }
        public void Update(int id, Customer customer)
        {
            using var context = new CoffeeShopDbContext();
            var fCustomer = context.Customers.SingleOrDefault(customer => customer.Id == id);
            if (fCustomer is null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            fCustomer.Code = customer.Code;
            fCustomer.Description = customer.Description;
            fCustomer.Transactions = customer.Transactions;
            context.SaveChanges();
        }
        public Customer? GetById(int id)
        {
            using var context = new CoffeeShopDbContext();
            var fCustomer = context.Customers.Include(customer => customer.Transactions).SingleOrDefault(customer => customer.Id == id);
            return fCustomer;
        }
        public List<Customer> GetAll()
        {
            using var context = new CoffeeShopDbContext();
            var fCustomers = context.Customers.ToList();
            return fCustomers;
        }
    }
}