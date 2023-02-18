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
    public class EmployeeRepo : IEntityRepo<Employee>
    {

        public IList<Employee> GetAll()
        {
            using var context = new FuelStationDbContext();
            var dbEmployee = context.Employees
                .Include(ee => ee.Transactions)
                .ToList();
            return dbEmployee;
        }

        public Employee? GetById(Guid id)
        {
            using var context = new FuelStationDbContext();
            var dbEmployee = context.Employees
                .Include(ee => ee.Transactions)
                .SingleOrDefault(ee => ee.ID == id);
            return dbEmployee;
        }

        public void Add(Employee employee)
        {
            if (employee.ID != Guid.Empty)
            {
                throw new ArgumentException("Given entity should not have an ID set", nameof(employee));
            }
            using var context = new FuelStationDbContext();
            context.Add(employee);
            context.SaveChanges();
        }

        public void Update(Guid id, Employee employee)
        {
            using var context = new FuelStationDbContext();
            var dbEmployee = context.Employees
                .Include(ee => ee.Transactions)
                .SingleOrDefault(ee => ee.ID == id);
            if (dbEmployee == null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            dbEmployee.Name = employee.Name;
            dbEmployee.Surname = employee.Surname;
            dbEmployee.HireDateEnd = employee.HireDateEnd;
            dbEmployee.SalaryPerMonth = employee.SalaryPerMonth;
            dbEmployee.EmployeeType = employee.EmployeeType;
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            using var context = new FuelStationDbContext();
            var dbEmployee = context.Employees
                .SingleOrDefault(ee => ee.ID == id);
            if (dbEmployee == null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            context.Remove(dbEmployee);
            context.SaveChanges();
        }
    }
}
