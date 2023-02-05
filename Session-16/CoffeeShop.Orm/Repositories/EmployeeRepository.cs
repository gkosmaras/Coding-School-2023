using CoffeeShop.Model;
using CoffeeShop.Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Orm.Repositories
{
    public class EmployeeRepository : IEntityRepository<Employee>
    {
        public void Add(Employee ent)
        {
            using var context = new AddDbContext();
            context.Employees.Add(ent);
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            using var context = new AddDbContext();
            var tempEe = context.Employees.SingleOrDefault(ee => ee.ID == id);
            if (tempEe is null)
                return;
            context.Employees.Remove(tempEe);
            context.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            using var context = new AddDbContext();
            return context.Employees.ToList();
        }

        public Employee? GetById(Guid id)
        {
            using var context = new AddDbContext();
            return context.Employees.Where(ee => ee.ID == id).SingleOrDefault();
        }

        public void Update(Guid id, Employee ent)
        {
            using var context = new AddDbContext();
            var tempEe = context.Employees.SingleOrDefault(ee => ee.ID == id);
            if (tempEe is null)
                return;
            tempEe.ID = ent.ID;
            tempEe.Name = ent.Name;
            tempEe.Surname = ent.Surname;
            tempEe.TypeOfEmployee = ent.TypeOfEmployee;
            tempEe.SalaryPerMonth = ent.SalaryPerMonth;
            context.SaveChanges();
        }
    }
}
