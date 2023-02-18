using FuelStation.EF.Context;
using FuelStation.Model.People;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories
{
    public class CustomerRepo :IEntityRepo<Customer>
    {

        public IList<Customer> GetAll()
        {
            using var context = new FuelStationDbContext();
            var dbCustomer = context.Customers
                .Include(cus => cus.Transactions)
                .ToList();
            return dbCustomer;
        }

        public Customer? GetById(Guid id)
        {
            using var context = new FuelStationDbContext();
            var dbCustomer = context.Customers
                .Include(cus => cus.Transactions)
                .SingleOrDefault(cus => cus.ID == id);
            return dbCustomer;
        }

        public void Add(Customer customer)
        {
            if (customer.ID != Guid.Empty)
            {
                throw new ArgumentException("Given entity should not have an ID set", nameof(customer));
            }
            using var context = new FuelStationDbContext();
            context.Add(customer);
            context.SaveChanges();
        }

        public void Update(Guid id, Customer customer)
        {
            using var context = new FuelStationDbContext();
            var dbCustomer = context.Customers
                .Include(cus => cus.Transactions)
                .SingleOrDefault(cus => cus.ID == id);
            if (dbCustomer == null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            dbCustomer.Name = customer.Name;
            dbCustomer.Surname = customer.Surname;
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            using var context = new FuelStationDbContext();
            var dbCustomer = context.Customers
                .SingleOrDefault(cus => cus.ID == id);
            if (dbCustomer == null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            context.Remove(dbCustomer);
            context.SaveChanges();
        }
    }
}
