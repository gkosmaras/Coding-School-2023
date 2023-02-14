using PetShop.Models.Enums;

namespace PetShop.Models {

    public class PetFood {

        public int Id { get; set; }
        public AnimalType AnimalType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }

        public PetFood(AnimalType animalType, decimal price, decimal cost) {
            AnimalType = animalType;
            Price = price;
            Cost = cost;
            Transactions = new List<Transaction>();
        }

    }

}
