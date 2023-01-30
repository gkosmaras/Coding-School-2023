using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library {
    public class Product  {

        public enum ProductType {
            Coffee,
            Beverages,
            Food
        }

        //Properties

        public Guid ID { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public Guid ProductCategoryID { get; set; }
        public ProductType TypeOfProduct { get; set; }
        
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        

        //Constractors
        public Product()
        {
            ID = Guid.NewGuid();
            ProductCategoryID = Guid.NewGuid();
        }
    }
}
