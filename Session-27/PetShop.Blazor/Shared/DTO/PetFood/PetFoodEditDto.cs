using System.ComponentModel.DataAnnotations;
using PetShop.Models.Enums;

namespace PetShop.Blazor.Shared.DTO.PetFood {

    public class PetFoodEditDto {

        public int Id { get; set; }
        [Required]
        public AnimalType AnimalType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

    }

}