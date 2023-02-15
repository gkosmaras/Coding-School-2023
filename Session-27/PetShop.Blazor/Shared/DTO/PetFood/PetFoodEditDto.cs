using PetShop.Models.Enums;

namespace PetShop.Blazor.Shared.DTO.PetFood {

    public class PetFoodEditDto {

        public int Id { get; set; }
        public AnimalType AnimalType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

    }

}