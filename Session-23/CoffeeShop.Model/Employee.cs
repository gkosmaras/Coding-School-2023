using CoffeeShop.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Model
{
    public class Employee
    {
        public Employee(string name, string surname, int salaryPerMonth, EmployeeType employeeType)
        {
            Name = name;
            Surname = surname;
            SalaryPerMonth = salaryPerMonth;
            EmployeeType = employeeType;

            Transactions = new List<Transaction>();
        }
        [Display(Name = "Employee ID")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Display(Name = "Monthly salary")]
        public int SalaryPerMonth { get; set; }
        [Display(Name = "Type of employee")]
        public EmployeeType EmployeeType { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
    public class EmployeeCreateDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        [Display(Name = "Monthly salary")]
        public int SalaryPerMonth { get; set; }
        [Display(Name = "Type of employee")]
        public EmployeeType EmployeeType { get; set; }
    }
    public class EmployeeEditDto
    {
        [Display(Name = "Employee ID")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Display(Name = "Monthly salary")]
        public int SalaryPerMonth { get; set; }
        [Display(Name = "Type of employee")]
        public EmployeeType EmployeeType { get; set; }
    }
    public class EmployeeDeleteDto
    {
        [Display(Name = "Employee ID")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Display(Name = "Monthly salary")]
        public int SalaryPerMonth { get; set; }
        [Display(Name = "Type of employee")]
        public EmployeeType EmployeeType { get; set; }
    }
    public class EmployeeDetailsDto
    {
        [Display(Name = "Employee ID")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Display(Name = "Monthly salary")]
        public int SalaryPerMonth { get; set; }
        [Display(Name = "Type of employee")]
        public EmployeeType EmployeeType { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
