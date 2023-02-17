using PetShop.Blazor.Shared.DTO.Transaction;
using PetShop.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Blazor.Shared.DTO.Employee
{
    public class EmployeeEditDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "Surname is required")]
        public string Surname { get; set; } = null!;
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Type of employee is required")]
        public EmployeeType EmployeeType { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Salary can not be negative")]
        public int SalaryPerMonth { get; set; }
        public List<TransactionDto> Transactions { get; set; } = new();
    }
}
