using System;



namespace CoffeeShop.Model
{
    public class Customer
    { 
        public Guid ID { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public Transaction Transaction { get; set; }
        public Customer() {
            ID = Guid.NewGuid();
            Code= 001;
            Description ="Retail Customer";
        }
    }
}



