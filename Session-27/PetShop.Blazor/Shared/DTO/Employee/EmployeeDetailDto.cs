using PetShop.Blazor.Shared.DTO.Customer;
using PetShop.Blazor.Shared.DTO.Transaction;
using PetShop.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Blazor.Shared.DTO.Employee
{
    public class EmployeeDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public EmployeeType EmployeeType { get; set; }
        public int SalaryPerMonth { get; set; }
        public List<TransactionDto> Transactions { get; set; } = new();
    }
}
