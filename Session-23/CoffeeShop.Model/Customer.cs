using CoffeeShop.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Model
{
    public class Customer
    {
        public Customer(string code, string description)
        {
            Code = code;
            Description = description;
            Transactions = new List<Transaction>();
        }
        public Customer()
        {
            Transactions = new List<Transaction>();
        }


        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
    public class CustomerCreateDto
    {
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
    public class CustomerEditDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
    public class CustomerDeleteDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
    public class CustomerDetailsDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction> ();

    }
}
