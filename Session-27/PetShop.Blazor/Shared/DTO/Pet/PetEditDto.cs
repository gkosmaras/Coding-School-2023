using PetShop.Models.Enums;

namespace PetShop.Blazor.Shared.DTO.Pet {

    public class PetEditDto {

        public int Id { get; set; }
        public string Breed { get; set; } = null!;
        public AnimalType AnimalType { get; set; }
        public PetStatus PetStatus { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

    }

}