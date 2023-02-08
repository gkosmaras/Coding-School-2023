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
    public class MockCustomerRepo : IEntityRepo<Customer>
    {
        private readonly List<Customer> _customers;
        public MockCustomerRepo()
        {
            _customers = new List<Customer>
            {
                new Customer("001", "Retail"),
                new Customer("002", "Retail")
            };
        }
        public List<Customer> GetAll()
        {
            return _customers.ToList();
        }
        public Customer? GetById(int id)
        {
            return _customers.SingleOrDefault(customer => customer.Id == id);
        }
        public void Create(Customer customer)
        {
            if (customer.Id != 0)
            {
                throw new ArgumentException("Given customer should not have an ID set", nameof(customer));
            }
            var lastId = _customers.OrderBy(customer => customer.Id).Last().Id;
            customer.Id = ++lastId;
            _customers.Add(customer);

        }
        public void Delete(int id)
        {
            var fCustomer = _customers.SingleOrDefault(customer => customer.Id == id);
            if (fCustomer is null) 
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found");
            }
            _customers.Remove(fCustomer);
        }
        public void Update(int id, Customer customer)
        {
            var fCustomer = _customers.SingleOrDefault(customer => customer.Id == id);
            if (fCustomer is null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found");
            }
            fCustomer.Code = customer.Code;
            fCustomer.Description = customer.Description;
            fCustomer.Transactions = customer.Transactions;
        }
    }
}
