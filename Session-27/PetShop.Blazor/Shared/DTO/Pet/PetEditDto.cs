using PetShop.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Blazor.Shared.DTO.Pet {

    public class PetEditDto {

        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the pet's breed")]
        public string Breed { get; set; } = null!;
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter the pet's type")]
        public AnimalType AnimalType { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter the pet's health status")]
        public PetStatus PetStatus { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

    }

}