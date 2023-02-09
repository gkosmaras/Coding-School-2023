using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using CoffeeShop.EF.Repositories;
using CoffeeShop.Model.Enums;

namespace CoffeeShop.EF.Repositories
{
    public class MockEmployeeRepo : IEntityRepo<Employee>
    {
        private readonly List<Employee> _employees;
        public MockEmployeeRepo()
        {
            _employees = new List<Employee>
            {
                new Employee("Name1", "Surname1", 1111, Model.Enums.EmployeeType.Manager),
                new Employee("Name2", "Surname2", 2222, Model.Enums.EmployeeType.Cashier),
                new Employee("Name3", "Surname3", 3333, (EmployeeType) 3),
                new Employee("Name4", "Surname4", 4444, (EmployeeType) 4)
            };
        }
        public List<Employee> GetAll()
        {
            return _employees.ToList();
        }
        public Employee? GetById(int id)
        {
            return _employees.FirstOrDefault(employee => employee.Id == id);
        }
        public void Create(Employee employee)
        {
            if (employee.Id != 0)
            {
                throw new ArgumentException("Given employee should not have an ID set", nameof(employee));
            }
            var lastId = _employees.OrderBy(employee => employee.Id).Last().Id;
            employee.Id = ++lastId;
            _employees.Add(employee);
        }
        public void Delete(int id)
        {
            var fEmployee = _employees.SingleOrDefault(employee => employee.Id == id);
            if (fEmployee is null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found");
            }
            _employees.Remove(fEmployee);
        }
        public void Update(int id, Employee employee)
        {
            var fEmployee = _employees.SingleOrDefault(employee => employee.Id == id);
            if (fEmployee is null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found");
            }
            fEmployee.Name = employee.Name;
            fEmployee.Surname = employee.Surname;
            fEmployee.SalaryPerMonth = employee.SalaryPerMonth;
            fEmployee.EmployeeType = employee.EmployeeType;
        }
    }
}
