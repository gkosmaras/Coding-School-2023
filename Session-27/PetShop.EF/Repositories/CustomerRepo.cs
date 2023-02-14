using Microsoft.EntityFrameworkCore;
using PetShop.EF.Context;
using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories
{
    public class CustomerRepo : IEntityRepo<Customer>
    {
        public void Add(Customer customer)
        {
            using var context = new PetShopDbContext();
            if (customer.Id != 0)
            {
                throw new ArgumentException("Given entity should not have an ID set", nameof(customer));
            }
            context.Add(customer);
            context.SaveChanges();
        }
        public void Update(int id, Customer customer)
        {
            using var context = new PetShopDbContext();
            var dbCustomer = context.Customers.Where(cus => cus.Id == id).SingleOrDefault();
            if (customer.Id == 0)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            dbCustomer.Name = customer.Name;
            dbCustomer.Surname = customer.Surname;
            dbCustomer.Phone = customer.Phone;
            dbCustomer.Tin = customer.Tin;
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            using var context = new PetShopDbContext();
            var dbCustomer = context.Customers.Where(cus => cus.Id == id).SingleOrDefault();
            if (dbCustomer == null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            context.Remove(dbCustomer);
            context.SaveChanges();
        }
        public Customer? GetById(int id)
        {
            using var context = new PetShopDbContext();
            var dbCustomer = context.Customers.Include(cus => cus.Transactions).Where(cus => cus.Id == id).SingleOrDefault();
            return dbCustomer;
        }
        public IList<Customer> GetAll()
        {
            using var context = new PetShopDbContext();
            var dbCustomer = context.Customers.Include(cus => cus.Transactions).ToList();
            return dbCustomer;
        }
    }
    
}
