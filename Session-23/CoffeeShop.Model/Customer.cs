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
        [Display(Name = "Customer ID")]
        public int Id { get; set; }
        [Display(Name = "Customer Code")]
        public string Code { get; set; }
        [Display(Name = "Customer Description")]
        public string Description { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
    public class CustomerCreateDto
    {
        [Display(Name = "Customer Code")]
        public string Code { get; set; } = null!;
        [Display(Name = "Customer Description")]
        public string Description { get; set; } = null!;
    }
    public class CustomerEditDto
    {
        [Display(Name = "Customer ID")]
        public int Id { get; set; }
        [Display(Name = "Customer Code")]
        public string Code { get; set; }
        [Display(Name = "Customer Description")]
        public string Description { get; set; }
    }
    public class CustomerDeleteDto
    {
        [Display(Name = "Customer ID")]
        public int Id { get; set; }
        [Display(Name = "Customer Code")]
        public string Code { get; set; }
        [Display(Name = "Customer Description")]
        public string Description { get; set; }
    }
    public class CustomerDetailsDto
    {
        [Display(Name = "Customer ID")]
        public int Id { get; set; }
        [Display(Name = "Customer Code")]
        public string Code { get; set; }
        [Display(Name = "Customer Description")]
        public string Description { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction> ();

    }
}
