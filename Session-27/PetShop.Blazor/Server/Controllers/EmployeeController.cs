using Microsoft.AspNetCore.Mvc;
using PetShop.Blazor.Shared.DTO.Employee;
using PetShop.EF.Repositories;
using PetShop.Models;

namespace PetShop.Blazor.Server.Controllers {

    [Route("[controller]")]
    [ApiController]

    public class EmployeeController : ControllerBase {

        private readonly IEntityRepo<Employee> _employeeRepo;

        public EmployeeController(IEntityRepo<Employee> employeeRepo) {
            _employeeRepo = employeeRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeDto>> Get() {

            var dbEmployee = _employeeRepo.GetAll();

            var result = dbEmployee.Select(ee => new EmployeeDto {
                Id = ee.Id,
                Name = ee.Name,
                Surname = ee.Surname,
                EmployeeType = ee.EmployeeType,
                SalaryPerMonth = ee.SalaryPerMonth,
            });

            return result;

        }

        [HttpGet("{id}")]
        public async Task<EmployeeEditDto> GetById(int id) {

            var dbEmployee = _employeeRepo.GetById(id);

            if (dbEmployee == null) {
                throw new ArgumentNullException();
            }

            var result = new EmployeeEditDto {
                Id = id,
                Name = dbEmployee.Name,
                Surname = dbEmployee.Surname,
                EmployeeType = dbEmployee.EmployeeType,
                SalaryPerMonth = dbEmployee.SalaryPerMonth,
            };

            return result;

        }

        [HttpPost]
        public async Task Post(EmployeeEditDto employee) {

            var dbEmployee = new Employee(
                employee.Name,
                employee.Surname,
                employee.EmployeeType,
                employee.SalaryPerMonth
                );

            _employeeRepo.Add(dbEmployee);
        }

        [HttpPut]
        public async Task Put(EmployeeEditDto employee) {

            var dbEmployee = _employeeRepo.GetById(employee.Id);

            if (dbEmployee == null) {
                throw new ArgumentNullException();
            }

            dbEmployee.Name = employee.Name;
            dbEmployee.Surname = employee.Surname;
            dbEmployee.EmployeeType = employee.EmployeeType;
            dbEmployee.SalaryPerMonth = employee.SalaryPerMonth;

            _employeeRepo.Update(employee.Id, dbEmployee);

        }

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            _employeeRepo.Delete(id);
        }

    }

}