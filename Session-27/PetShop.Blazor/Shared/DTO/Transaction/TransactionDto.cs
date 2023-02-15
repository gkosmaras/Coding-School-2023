namespace PetShop.Blazor.Shared.DTO.Transaction {

    public class TransactionDto {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal PetPrice { get; set; }
        public int PetFoodQty { get; set; }
        public decimal PetFoodPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string PetBreed { get; set; }

    }

}