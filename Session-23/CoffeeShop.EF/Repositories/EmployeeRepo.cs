using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repositories
{
    public class EmployeeRepo : IEntityRepo<Employee>
    {
        public void Create(Employee employee) 
        {
            using var context = new CoffeeShopDbContext();
            if (employee.Id != 0)
            {
                throw new ArgumentException("Given employee should not have an ID set", nameof(employee));
            }
            context.Employees.Add(employee);
            context.SaveChanges();
        }
        public void Delete (int id)
        {
            using var context = new CoffeeShopDbContext();
            var fEmployee = context.Employees.SingleOrDefault(employee => employee.Id == id);
            if (fEmployee is null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            context.Employees.Remove(fEmployee);
            context.SaveChanges();
        }
        public void Update(int id, Employee employee)
        {
            using var context = new CoffeeShopDbContext();
            var fEmployee = context.Employees.SingleOrDefault(employee => employee.Id == id);
            if (fEmployee is null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            fEmployee.Name = employee.Name;
            fEmployee.Surname = employee.Surname;
            fEmployee.SalaryPerMonth = employee.SalaryPerMonth;
            fEmployee.EmployeeType = employee.EmployeeType;
            fEmployee.Transactions = employee.Transactions;
            context.SaveChanges();
        }
        public Employee? GetById(int id)
        {
            using var context = new CoffeeShopDbContext();
            var fEmployee = context.Employees.Include(ee=> ee.Transactions).Where(ee => ee.Id == id).FirstOrDefault();
            return fEmployee;
        }
        public List<Employee> GetAll()
        {
            using var context = new CoffeeShopDbContext();
            var fEmployees = context.Employees.ToList();
            return fEmployees;
        }
    }
}
