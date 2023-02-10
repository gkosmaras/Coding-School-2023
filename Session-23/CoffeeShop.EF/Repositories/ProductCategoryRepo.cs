using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repositories
{
    public class ProductCategoryRepo : IEntityRepo<ProductCategory>
    {
        public void Create(ProductCategory productCategory)
        {
            using var context = new CoffeeShopDbContext();
            if (productCategory.Id != 0)
            {
                throw new ArgumentException("Given product category should not have an ID set", nameof(productCategory));
            }
            context.ProductCategories.Add(productCategory);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new CoffeeShopDbContext();
            var fProductCategory = context.ProductCategories.SingleOrDefault(productCategory => productCategory.Id == id);
            if (fProductCategory is null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            context.ProductCategories.Remove(fProductCategory);
            context.SaveChanges();
        }
        public void Update(int id, ProductCategory productCategory)
        {
            using var context = new CoffeeShopDbContext();
            var fProductCategory = context.ProductCategories.SingleOrDefault(productCategory => productCategory.Id == id);
            if (fProductCategory is null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            fProductCategory.Code = productCategory.Code;
            fProductCategory.Description = productCategory.Description;
            fProductCategory.ProductType = productCategory.ProductType;
            fProductCategory.Products = productCategory.Products;

        }
        public ProductCategory? GetById(int id)
        {
            using var context = new CoffeeShopDbContext();
            var fProductCategory = context.ProductCategories.Include(prodCat => prodCat.Products).Where(productCategory => productCategory.Id == id).SingleOrDefault();
            return fProductCategory;
        }
        public List<ProductCategory> GetAll()
        {
            using var context = new CoffeeShopDbContext();
            var fProductCategories = context.ProductCategories.Include(prodCat => prodCat.Products).ToList();
            return fProductCategories;
        }
    }
}
