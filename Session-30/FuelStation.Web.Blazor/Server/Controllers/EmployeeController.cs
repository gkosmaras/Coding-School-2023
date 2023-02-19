using FuelStation.EF.Repositories;
using FuelStation.Model.People;
using FuelStation.Web.Blazor.Shared.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Web.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEntityRepo<Employee> _employeeRepo;

        public EmployeeController(IEntityRepo<Employee> employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeEditDto>> Get()
        {
            var dbEmployee = _employeeRepo.GetAll();

            var result = dbEmployee.Select(ee => new EmployeeEditDto
            {
                ID = ee.ID,
                Name = ee.Name,
                Surname = ee.Surname,
                HireDateStart = ee.HireDateStart,
                HireDateEnd = ee.HireDateEnd,
                SalaryPerMonth = ee.SalaryPerMonth,
                EmployeeType = ee.EmployeeType,
            });
            return result;
        }

        [HttpGet("{id}")]
        public async Task<EmployeeEditDto> GetById(int id)
        {
            var dbEmployee = _employeeRepo.GetById(id);

            if (dbEmployee == null)
            {
                throw new ArgumentNullException();
            }

            var result = new EmployeeEditDto
            {
                ID = id,
                Name = dbEmployee.Name,
                Surname = dbEmployee.Surname,
                HireDateStart = dbEmployee.HireDateStart,
                HireDateEnd = dbEmployee.HireDateEnd,
                SalaryPerMonth = dbEmployee.SalaryPerMonth,
                EmployeeType = dbEmployee.EmployeeType,
            };

            return result;
        }

        [HttpPost]
        public async Task Post(EmployeeEditDto employee)
        {
            Employee dbEmployee = new()
            {
                Name = employee.Name,
                Surname = employee.Surname,
                HireDateStart = DateTime.Now,
                HireDateEnd = employee.HireDateEnd,
                SalaryPerMonth = employee.SalaryPerMonth,
                EmployeeType = employee.EmployeeType,
            };
            _employeeRepo.Add(dbEmployee);
        }

        [HttpPut]
        public async Task Put(EmployeeEditDto employee)
        {

            var dbEmployee = _employeeRepo.GetById(employee.ID);

            if (dbEmployee == null)
            {
                throw new ArgumentNullException();
            }
            dbEmployee.Name = employee.Name;
            dbEmployee.Surname = employee.Surname;
            dbEmployee.HireDateEnd = employee.HireDateEnd;
            dbEmployee.SalaryPerMonth = employee.SalaryPerMonth;
            dbEmployee.EmployeeType = employee.EmployeeType;

            _employeeRepo.Update(employee.ID, dbEmployee);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _employeeRepo.Delete(id);
        }
    }
}
