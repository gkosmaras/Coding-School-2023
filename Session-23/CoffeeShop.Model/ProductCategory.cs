using CoffeeShop.Model.Enums;

namespace CoffeeShop.Model
{
    public class ProductCategory
    {
        public ProductCategory(string code, string description, ProductType productType)
        {
            Code = code;
            Description = description;
            ProductType = productType;

            Products = new List<Product>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ProductType ProductType { get; set; }

        // Relations
        public List<Product> Products { get; set; }
    }
    public class ProductCategoryCreateDto
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public ProductType ProductType { get; set; }
    }
    public class ProductCategoryEditDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ProductType ProductType { get; set; }
    }
    public class ProductCategoryDeleteDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ProductType ProductType { get; set; }
    }
    public class ProductCategoryDetailsDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ProductType ProductType { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
