using PetShop.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Blazor.Shared.DTO.Pet {

    public class PetDto {

        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the pet's breed")]
        public string Breed { get; set; } = null!;
        public AnimalType AnimalType { get; set; }
        public PetStatus PetStatus { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

    }

}