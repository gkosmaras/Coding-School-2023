using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model
{
    public class TransactionLine : IEntityBase
    {
        public Guid ID { get; set; }
        public Guid ProductID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalCost { get; set; }        
        public decimal TotalPrice { get; set; }
        public Transaction Transaction { get; set; }
        public Product Product { get; set; }

        public TransactionLine()
        {
            ID = Guid.NewGuid();
            Date= DateTime.Now;
        }
    }
}


