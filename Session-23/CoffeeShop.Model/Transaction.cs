using CoffeeShop.Model.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoffeeShop.Model
{
    public class Transaction
    {
        public Transaction(decimal totalPrice, PaymentMethod paymentMethod)
        {
            Date = DateTime.Now;
            TotalPrice = totalPrice;
            PaymentMethod = paymentMethod;

            TransactionLines = new List<TransactionLine>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        // Relations
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;

        public List<TransactionLine> TransactionLines { get; set; }
    }
    public class TransactionCreateDto
    {
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public int CustomerId { get; set; }
        public List<SelectListItem> Customers { get; set; } = new List<SelectListItem>();
        public int EmployeeId { get; set; }
        public List<SelectListItem> Employees { get; set; } = new List<SelectListItem>();
    }
    public class TransactionEditDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public int CustomerId { get; set; }
        public List<SelectListItem> Customers { get; set; } = new List<SelectListItem>();
        public int EmployeeId { get; set; }
        public List<SelectListItem> Employees { get; set; } = new List<SelectListItem>();
    }
    public class TransactionDeleteDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
    public class TransactionDetailsDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public int CustomerId { get; set; }
        public Customer Customers { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employees { get; set; }
        public List<TransactionLine> TransactionLines { get; set; } = new List<TransactionLine>();
    }
}
