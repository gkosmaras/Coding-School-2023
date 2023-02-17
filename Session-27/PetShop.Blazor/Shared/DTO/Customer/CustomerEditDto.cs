using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Blazor.Shared.DTO.Transaction;

namespace PetShop.Blazor.Shared.DTO.Customer
{
    public class CustomerEditDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Surname { get; set; } = null!;
        public int Phone { get; set; }
        [Required]
        public string Tin { get; set; } = null!;
        public List<TransactionDto> Transactions { get; set; } = new();
    }
}
