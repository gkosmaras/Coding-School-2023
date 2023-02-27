using FuelStation.EF.Context;
using FuelStation.Model;
using FuelStation.Model.Enums;
using FuelStation.Model.People;
using FuelStation.Web.Blazor.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FuelStation.Web.Blazor.Shared.Validators
{
    public struct MinMax
    {
        public int Min;
        public int Max;
    }
    public class Validator : IValidator
    {
        private FuelStationDbContext context = new FuelStationDbContext();
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

        public bool ValidateAddItem(int code, out String errorMessage)
        {
            errorMessage = "Success";
            bool result = true;
            var codes = context.Items.Select(it => it.Code);
            if (codes.Contains(code))
            {
                result = false;
                errorMessage = $"Item code '{code}' already exists!";
            }
            return result;
        }

        public bool ValidateUpdateItem(int code, Item dbItem, out string errorMessage)
        {
            errorMessage = "Success";
            bool result = true;
            if (dbItem == null)
            {
                result = false;
            }
            else if(code != dbItem.Code)
            {
                var codes = context.Items.Select(it => it.Code);
                if (codes.Contains(code))
                {
                    result = false;
                    errorMessage = $"Item code '{code}' already exists!";
                }
            }
            return result;
        }

        public bool StringCheck(string name, string surname)
        {
            return String.IsNullOrWhiteSpace(name) || String.IsNullOrWhiteSpace(surname);
        }
        public string GetCardNumber()
        {
            Random generator = new Random();
        Generate:
            string cn = generator.Next(0, 10000000).ToString("D7");
            cn = string.Concat("A-", cn);
            if (CheckCardUniqueness(cn))
            {
                goto Generate;
            }
            return cn;
        }

        public bool CheckCardUniqueness(string cn)
        {
            var dbCustomer = context.Customers.Select(cus => cus.CardNumber);
            bool result = dbCustomer.Contains(cn);
            return result;
        }

        public bool DecCheck(decimal price, decimal cost)
        {
            return price < 0 || cost < 0;
        }

        public bool ValidateCode(int code, int oldCode)
        {
            bool result = true;
            if (code != oldCode)
            {
                var codes = context.Items.Select(it => it.Code);
                if (codes.Contains(code))
                {
                    result = false;
                }
            }
            return result;
        }

        public int ExistingCustomer(string code)
        {
            int id = 0;
            if (CheckCardUniqueness(code))
            {
                id = context.Customers.SingleOrDefault(cus => cus.CardNumber == code).ID;
            }
            return id;
        }

        public bool ValidateFuel(TransactionLineEditDto transLine, int oldId)
        {
            bool result = true;
            var items = context.TransactionLines
                .Where(trans => trans.TransactionID == transLine.TransactionID).Select(x => x.ItemID).ToList();
            var fuels = context.Items.Where(it => it.ItemType == ItemType.Fuel).Select(x => x.ID).ToList();
            bool hasFuel = fuels.Any(it => items.Contains(it));
            var oldType = context.Items.SingleOrDefault(x => x.ID == oldId).ItemType;
            var newItem = context.Items.SingleOrDefault(x => x.ID == transLine.ItemID);
            if (hasFuel && oldType != ItemType.Fuel)
            {
                if (newItem.ItemType == ItemType.Fuel)
                {
                    result = false;
                }
            }
            return result;
        }

        public bool CheckPayment(int trans)
        {
            bool result = true;
            var totalValue = context.TransactionLines.Where(x => x.TransactionID == trans).Sum(x => x.TotalValue);
            if (totalValue > 50)
            {
                result = false;
            }
            return result;
        }

        public int LoginCred(string username, string passKey)
        {
            int result = 0;
            var dbEmployee = context.Employees;
            string input = passKey.Remove(0, 8);
            Int32.TryParse(input, out int password);
            var user = (dbEmployee.SingleOrDefault(x => x.ID == password));
            if (username == (user.Name + user.Surname).ToLower())
            {
                if (user.EmployeeType == EmployeeType.Manager)
                {
                    result = 1;
                }
                else if (user.EmployeeType == EmployeeType.Cashier)
                {
                    result = 2;
                }
                else
                {
                    result = 3;
                }
            }
            else if (username == "admin" && passKey == "sysadmin")
            {
                result = 1;
            }
            return result;
        }
    }
}
