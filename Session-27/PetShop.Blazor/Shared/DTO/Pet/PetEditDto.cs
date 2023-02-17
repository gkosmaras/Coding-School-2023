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
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Price can not be negative")]
        public decimal Price { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Cost can not be negative")]
        public decimal Cost { get; set; }

    }

}