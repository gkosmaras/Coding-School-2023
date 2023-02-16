using PetShop.Blazor.Shared.DTO.Customer;
using PetShop.Blazor.Shared.DTO.Employee;
using PetShop.Blazor.Shared.DTO.Pet;
using PetShop.Blazor.Shared.DTO.PetFood;
using PetShop.Models;
using PetShop.Models.Enums;

namespace PetShop.Blazor.Shared.DTO.Transaction {

    public class TransactionDto {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal PetPrice { get; set; }
        public int PetFoodQty { get; set; }
        public decimal PetFoodPrice { get; set; }
        public decimal TotalPrice { get; set; }

        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public int PetId { get; set; }
        public int PetFoodId { get; set; }

        public string CustomerName { get; set; } = null!;
        public string CustomerSurname { get; set; } = null!;
        public string EmployeeName { get; set; } = null!;
        public string EmployeeSurname { get; set; } = null!;
        public string PetBreed { get; set; } = null!;
        public AnimalType PetFood { get; set; }

        public List<CustomerDto> Customers { get; set; } = new();
        public List<EmployeeDto> Employees { get; set; } = new();
        public List<PetDto> Pets { get; set; } = new();
        public List<PetFoodDto> PetFoods { get; set; } = new();
    }

}