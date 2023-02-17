using PetShop.Models;
using PetShop.Blazor.Shared.DTO.Customer;
using PetShop.Blazor.Shared.DTO.Employee;
using PetShop.Blazor.Shared.DTO.Pet;
using PetShop.Blazor.Shared.DTO.PetFood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Blazor.Shared.DTO.Transaction
{
    public class TransactionEditDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal PetPrice { get; set; }


        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity can not be negative")]
        public int PetFoodQty { get; set; }
        public decimal PetFoodPrice { get; set; }
        public decimal TotalPrice { get; set; }

        // Relations
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a customer")]
        public int CustomerId { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter an employee")]
        public int EmployeeId { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a pet")]
        public int PetId { get; set; }
        public int PetFoodId { get; set; }

        public List<CustomerEditDto> Customers { get; set; } = new();
        public List<EmployeeEditDto> Employees{ get; set; } = new();
        public List<PetEditDto> Pets { get; set; } = new();
        public List<PetFoodEditDto> PetFoods { get; set; } = new();
    }

}