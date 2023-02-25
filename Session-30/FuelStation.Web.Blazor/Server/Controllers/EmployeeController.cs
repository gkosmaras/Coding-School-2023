using FuelStation.EF.Repositories;
using FuelStation.Model.People;
using FuelStation.Web.Blazor.Shared.DTO;
using FuelStation.Web.Blazor.Shared.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace FuelStation.Web.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IValidator _validator;
        public string errorMessage = string.Empty;

        public EmployeeController(IEntityRepo<Employee> employeeRepo, IValidator validator)
        {
            _employeeRepo = employeeRepo;
            _validator = validator;
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
        public async Task<ActionResult> Post(EmployeeEditDto employee)
        {
            Employee newEmployee = new()
            {
                Name = employee.Name,
                Surname = employee.Surname,
                HireDateStart = DateTime.Now,
                HireDateEnd = (DateTime)employee.HireDateEnd,
                SalaryPerMonth = employee.SalaryPerMonth,
                EmployeeType = employee.EmployeeType,
            };

            var dbEmployee = _employeeRepo.GetAll().ToList();
            if (_validator.ValidateAddEmployee(newEmployee.EmployeeType, dbEmployee, out errorMessage))
            {
                try
                {
                    await Task.Run(() => { _employeeRepo.Add(newEmployee); });
                }
                catch (DbException ex)
                {
                    return BadRequest(ex.Message);
                }
                return Ok();
            }
            return BadRequest(errorMessage);

        }

        [HttpPut]
        public async Task<ActionResult> Put(EmployeeEditDto employee)
        {
            var dbEmployee = _employeeRepo.GetById(employee.ID);

            if (dbEmployee == null)
            {
                throw new ArgumentNullException();
            }

            if (_validator.ValidateUpdateEmployee(employee.EmployeeType, dbEmployee, _employeeRepo.GetAll().ToList(), out errorMessage))
            {
                dbEmployee.Name = employee.Name;
                dbEmployee.Surname = employee.Surname;
                dbEmployee.HireDateEnd = (DateTime)employee.HireDateEnd;
                dbEmployee.SalaryPerMonth = employee.SalaryPerMonth;
                dbEmployee.EmployeeType = employee.EmployeeType;
                try
                {
                    _employeeRepo.Update(employee.ID, dbEmployee);
                }
                catch (DbUpdateException ex)
                {
                    return BadRequest(ex.Message);
                }
                return Ok();
            }
            else
            {
                return BadRequest(errorMessage);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var employees = _employeeRepo.GetAll().ToList();
            if (_validator.ValidateDeleteEmployee(employees.Where(ee => ee.ID == id).Single().EmployeeType, employees, out errorMessage))
            {
                try
                {
                    await Task.Run(() => { _employeeRepo.Delete(id); });
                }
                catch (DbUpdateException)
                {
                    return BadRequest($"Could not delete this employee because it has transactions");
                }
                catch (KeyNotFoundException)
                {
                    return BadRequest($"Employee not found");
                }
                return Ok();
            }
            return BadRequest(errorMessage);
        }
    }
}
