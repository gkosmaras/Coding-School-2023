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
        [Required(ErrorMessage = "Name of customer is required")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "Surname of customer is required")]
        public string Surname { get; set; } = null!;
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Phone number of customer is required")]
        public int Phone { get; set; }
        [Required(ErrorMessage = "TIN of customer is required")]
        public string Tin { get; set; } = null!;
        public List<TransactionDto> Transactions { get; set; } = new();
    }
}
