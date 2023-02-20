using FuelStation.Model;
using FuelStation.Model.Enums;
using FuelStation.Model.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared.Validators
{
    public interface IValidator
    {
        bool ValidateAddEmployee(EmployeeType type, List<Employee> employees, out string errorMessage);
        bool ValidateDeleteEmployee(EmployeeType type, List<Employee> employees, out string errorMessage);
        bool ValidateUpdateEmployee(EmployeeType type, Employee dbEmployee, List<Employee> employees, out string errorMessage);
        bool ValidateAddItem(int code, out string errorMessage);
        bool ValidateUpdateItem(int code, Item dbItem, out string errorMessage);
    }
}
