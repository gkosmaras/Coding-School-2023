using FuelStation.Model;
using FuelStation.Model.Enums;
using FuelStation.Model.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared.Validators
{
    public struct MinMax
    {
        public int Min;
        public int Max;
    }
    public class Validator : IValidator
    {
        public readonly MinMax ManagersLimits;
        public readonly MinMax CashiersLimits;
        public readonly MinMax StaffLimits;

        public Validator()
        {
            ManagersLimits = new MinMax() { Min = 1, Max = 3 };
            CashiersLimits = new MinMax() { Min = 0, Max = 4 };
            StaffLimits = new MinMax() { Min = 0, Max = 10 };
        }
        public bool ValidateAddEmployee(EmployeeType type, List<Employee> employees, out string errorMessage)
        {
            errorMessage = "Success";
            bool result = true;
            var managers = employees.Where(ee => ee.EmployeeType == EmployeeType.Manager);
            var cashiers = employees.Where(ee => ee.EmployeeType == EmployeeType.Cashier);
            var staff = employees.Where(ee => ee.EmployeeType == EmployeeType.Staff);

            if (type == EmployeeType.Manager && managers.Count() >= ManagersLimits.Max)
            {
                result = false;
                errorMessage = $"You already have {ManagersLimits.Max} Managers. That's the limit!";
            }

            if (type == EmployeeType.Cashier && cashiers.Count() >= CashiersLimits.Max)
            {
                result = false;
                errorMessage = $"You already have {CashiersLimits.Max} Cashiers. That's the limit!";
            }
            
            if (type == EmployeeType.Staff && staff.Count() >= StaffLimits.Max)
            {
                result = false;
                errorMessage = $"You already have {StaffLimits.Max} Staff. That's the limit!";
            }
            return result;
        }

        public bool ValidateUpdateEmployee(EmployeeType type, Employee dbEmployee, List<Employee> employees, out String errorMessage)
        {
            errorMessage = "Success";
            bool result = true;
            if (dbEmployee == null)
            {
                result = false;
            }
            else if (type != dbEmployee.EmployeeType)
            {
                var managers = employees.Where(ee => ee.EmployeeType == EmployeeType.Manager);
                var cashiers = employees.Where(ee => ee.EmployeeType == EmployeeType.Cashier);
                var staff = employees.Where(ee => ee.EmployeeType == EmployeeType.Staff);

                if (dbEmployee.EmployeeType == EmployeeType.Manager && managers.Count() <= ManagersLimits.Min)
                {
                    errorMessage = $"Can not downgrade your last manager!";
                    result = false;
                }
                if (type == EmployeeType.Manager && managers.Count() >= ManagersLimits.Max)
                {
                    errorMessage = $"You already have {ManagersLimits.Max} Managers. Make some space and try again.";
                    result = false;
                }
                if (type == EmployeeType.Cashier && cashiers.Count() >= CashiersLimits.Max)
                {
                    errorMessage = $"You already have {CashiersLimits.Max} cashiers. Make some space and try again.";
                    result = false;
                }
                if (type == EmployeeType.Staff && staff.Count() >= StaffLimits.Max)
                {
                    errorMessage = $"You already have {StaffLimits.Max} Staff. Make some space and try again.";
                    result = false;
                }
            }
            return result;
        }

        public bool ValidateDeleteEmployee(EmployeeType type, List<Employee> employees, out String errorMessage)
        {
            bool result = true;
            errorMessage = "Success";
            var managers = employees.Where(ee => ee.EmployeeType == EmployeeType.Manager);

            if (type == EmployeeType.Manager && managers.Count() <= ManagersLimits.Min)
            {
                errorMessage = $"You can not delete your last manager!";
                result = false;
            }
            return result;
        }

        public bool ValidateAddItem(int code, List<Item> items, out String errorMessage)
        {
            errorMessage = "Success";
            bool result = true;
            var codes = items.Select(it => it.Code);

            if (codes.Contains(code))
            {
                result = false;
                errorMessage = $"Item code '{code}' already exists!";
            }
            return result;
        }

        public bool ValidateUpdateItem(int code, Item dbItem, List<Item> items, out string errorMessage)
        {
            errorMessage = "Success";
            bool result = true;
            if (dbItem == null)
            {
                result = false;
            }
            else if(code != dbItem.Code)
            {
                var codes = items.Select(it => it.Code);
                if (codes.Contains(code))
                {
                    result = false;
                    errorMessage = $"Item code '{code}' already exists!";
                }
            }
            return result;

        }
    }
}
