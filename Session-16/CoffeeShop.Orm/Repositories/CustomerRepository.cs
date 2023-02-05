using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Orm.Context;
using CoffeeShop.Orm.Repositories;

namespace CoffeeShop.EF.Repositories
{
/*    public class CustomerRepository : IEntityRepository<Customer>
    {
        public void Add(Customer ent)
        {
            using var context = new AddDbContext();
            context.Customer.Add(ent);
            context.SaveChanges();
        }
        public void Delete(Guid id)
        {
            using var context = new AddDbContext();
            var tempCus = context.Customers.SingleOrDefault(cus => cus.ID == id);
            if (tempCus is null)
                return;
            context.Customers.Remove(tempCus);
            context.SaveChanges();
        }
        public List<Customer> GetAll()
        {
            using var context = new AddDbContext();
            return context.Customers.ToList();
        }
        public Customer? GetById(Guid id)
        {
            using var context = new AddDbContext();
            return context.Customers.Where(cus => cus.ID == id).SingleOrDefault();
        }
        public void Update(Guid id, Customer ent)
        {
            using var context = new AddDbContext();
            var tempCus = context.Customers.SingleOrDefault(cus => cus.ID == id);
            if (tempCus is null)
                return;
            tempCus.Code = ent.Code;
            tempCus.Description = ent.Description;
            tempCus.Transaction = ent.Transaction;
            context.SaveChanges();
        }
    }*/
}
