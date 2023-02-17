using System.ComponentModel.DataAnnotations;
using PetShop.Models.Enums;

namespace PetShop.Blazor.Shared.DTO.PetFood {

    public class PetFoodEditDto {

        public int Id { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a type of animal")]
        public AnimalType AnimalType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

    }

}