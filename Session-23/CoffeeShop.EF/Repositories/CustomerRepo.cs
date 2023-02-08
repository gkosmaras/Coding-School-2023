using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using CoffeeShop.EF.Repositories;

namespace CoffeeShop.EF.Repositories
{
    public class CustomerRepo : IEntityRepo<Customer>
    {
        public void Create(Customer customer)
        {
            using var context = new CoffeeShopDbContext();
            context.Customers.Add(customer);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            using var context = new CoffeeShopDbContext();
            var fCustomer = context.Customers.SingleOrDefault(customer => customer.Id == id);
            if (fCustomer == null)
            {
                return;
            }
            context.Customers.Remove(fCustomer);
            context.SaveChanges();
        }
        public void Update(int id, Customer customer)
        {
            using var context = new CoffeeShopDbContext();
            var fCustomer = context.Customers.SingleOrDefault(customer => customer.Id == id);
            if (fCustomer == null)
                return;
            fCustomer.Code = customer.Code;
            fCustomer.Description = customer.Description;
            fCustomer.Transactions = customer.Transactions;
            context.SaveChanges();
        }
        public Customer? GetById(int id)
        {
            using var context = new CoffeeShopDbContext();
            var fCustomer = context.Customers.Where(customer => customer.Id == id).SingleOrDefault();
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