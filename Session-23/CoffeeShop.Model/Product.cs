using CoffeeShop.Model.Enums;

namespace CoffeeShop.Model
{
    public class Product
    {
        public Product(string code, string description, decimal price, decimal cost)
        {
            Code = code;
            Description = description;
            Price = price;
            Cost = cost;

            TransactionLines = new List<TransactionLine>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        // Relations
        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; } = null!;

        public List<TransactionLine> TransactionLines { get; set; }
    }
    public class ProductCreateDto

    {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public int ProductCategoryId { get; set; }
    }
    public class ProductEditDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public int ProductCategoryId { get; set; }
    }
    public class ProductDeleteDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public int ProductCategoryId { get; set; }
    }
    public class ProductDetailsDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public int ProductCategoryId { get; set; }
        public ProductType ProductType { get; set; }
        public List<TransactionLine> TransactionLines { get; set; } = new List<TransactionLine>();
        
    }
}
