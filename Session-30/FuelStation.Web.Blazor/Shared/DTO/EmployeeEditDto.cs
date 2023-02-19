using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared.DTO
{
    public class EmployeeEditDto
    { 
        public int ID { get; set; }

        [Required(ErrorMessage = "Name of employee is required")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Surname of employee is required")]
        public string Surname { get; set; } = null!;

        public DateTime HireDateStart { get; set; }

        [Required(ErrorMessage ="Employment end date is required")]
        [WithinBounds]
        public DateTime? HireDateEnd { get; set; }

        [Required(ErrorMessage = "Salary of employee is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Salary can not be negative")]
        public decimal SalaryPerMonth { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Type of employee is required")]
        public EmployeeType EmployeeType { get; set; }
    }

    public class WithinBoundsAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            value = (DateTime)value;
            if (DateTime.MaxValue.CompareTo(value) >= 0 && DateTime.Now.CompareTo(value) < 0)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("End of employment can not be before the start!");
            }
        }
    }
}
