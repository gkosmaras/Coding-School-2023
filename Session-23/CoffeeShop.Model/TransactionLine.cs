using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.Design;
using System.Transactions;

namespace CoffeeShop.Model
{
    public class TransactionLine
    {
        public TransactionLine(int quantity, decimal discount, decimal price, decimal totalPrice)
        {
            Quantity = quantity;
            Discount = discount;
            Price = price;
            TotalPrice = totalPrice;
        }

        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }

        // Relations
        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
    public class TransactionLineCreateDto
    {
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public int TransactionId { get; set; }
        public List<SelectListItem> Transactions { get; set; } = new List<SelectListItem>();
        public int ProductId { get; set; }
        public List<SelectListItem> Products { get; set; } = new List<SelectListItem>();
    }
    public class TransactionLineEditDto
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public int TransactionId { get; set; }
        public List<SelectListItem> Transaction { get; set; } = new List<SelectListItem>();
        public int ProductId { get; set; }
        public List<SelectListItem> Products { get; set; } = new List<SelectListItem>();
    }
    public class TransactionLineDeleteDto
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public int TransactionId { get; set; }
        public Product Product { get; set; }
        public Transaction Transaction { get; set; }
        public int ProductId { get; set; }
    }
    public class TransactionLineDetailsDto
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public int TransactionId { get; set; }
        public Product Product { get; set; }
        public Transaction Transaction { get; set; }
        public int ProductId { get; set; }
    }
}
