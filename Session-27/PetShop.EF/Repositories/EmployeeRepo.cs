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
    public class EmployeeRepo : IEntityRepo<Employee>
    {
        public void Add(Employee employee)
        {
            using var context = new PetShopDbContext();
            if (employee.Id != 0)
            {
                throw new ArgumentException("Given entity should not have an ID set", nameof(customer));
            }
            context.Add(employee);
            context.SaveChanges();
        }
        public void Update(int id, Employee employee)
        {
            using var context = new PetShopDbContext();
            var dbEmployee = context.Employees.Where(ee => ee.Id == id).SingleOrDefault();
            if (employee.Id == 0)
            {
                throw new KeyNotFoundException($"Giver ID '{id}' was not found in the database");
            }
            dbEmployee.Name = employee.Name;
            dbEmployee.Surname = employee.Surname;
            employee.EmployeeType = employee.EmployeeType;
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            using var context = new PetShopDbContext();
            var dbEmployee = context.Employees.Where(ee => ee.Id == id).SingleOrDefault();
            if (dbEmployee == null)
            {
                throw new KeyNotFoundException($"Giver ID '{id}' was not found in the database");
            }
            context.Remove(dbEmployee);
        }
        public Employee? GetById(int id)
        {
            using var context = new PetShopDbContext();
            var dbEmployee = context.Employees.Include(ee => ee.Transactions).Where(ee => ee.Id == id).SingleOrDefault();
            return dbEmployee;
        }
        public IList<Employee> GetAll()
        {
            using var context = new PetShopDbContext();
            var dbEmployee = context.Employees.Include(ee => ee.Transactions).ToList();
            return dbEmployee;
        }
    }
}
