using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CoffeeShop.Model.Product;

namespace CoffeeShop.Model
{
    public class ProductCategory {
        public Guid ID { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public ProductType ProductType { get; set; }
        public Product Product { get; set; }

        public ProductCategory()
        {
            ID = Guid.NewGuid();
           
        }
    }
}
