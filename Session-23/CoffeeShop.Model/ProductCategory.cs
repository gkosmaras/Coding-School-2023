using CoffeeShop.Model.Enums;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

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
        [Display(Name = "Category Code")]
        public string Code { get; set; }
        [Display(Name = "Category Description")]
        public string Description { get; set; }
        [Display(Name = "Type of product")]
        public ProductType ProductType { get; set; }

        // Relations
        public List<Product> Products { get; set; }
    }
    public class ProductCategoryCreateDto
    {
        [Display(Name = "Category Code")]
        public string Code { get; set; }
        [Display(Name = "Category Description")]
        public string Description { get; set; }
        [Display(Name = "Type of product")]
        public ProductType ProductType { get; set; }
    }
    public class ProductCategoryEditDto
    {
        public int Id { get; set; }
        [Display(Name = "Category Code")]
        public string Code { get; set; }
        [Display(Name = "Category Description")]
        public string Description { get; set; }
        [Display(Name = "Type of product")]
        public ProductType ProductType { get; set; }
    }
    public class ProductCategoryDeleteDto
    {
        public int Id { get; set; }
        [Display(Name = "Category Code")]
        public string Code { get; set; }
        [Display(Name = "Category Description")]
        public string Description { get; set; }
        [Display(Name = "Type of product")]
        public ProductType ProductType { get; set; }
    }
    public class ProductCategoryDetailsDto
    {
        public int Id { get; set; }
        [Display(Name = "Category Code")]
        public string Code { get; set; }
        [Display(Name = "Category Description")]
        public string Description { get; set; }
        [Display(Name = "Type of product")]
        public ProductType ProductType { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
