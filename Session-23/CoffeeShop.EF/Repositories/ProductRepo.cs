using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.EF.Repositories
{
    public class ProductRepo : IEntityRepo<Product>
    {
        public void Create(Product product)
        {
            using var context = new CoffeeShopDbContext();
            if (product.Id != 0)
            {
                throw new ArgumentException("Given product should not have an ID set", nameof(product));
            }
            context.Products.Add(product);
            context.SaveChanges();
        }
        public void Delete (int id)
        {
            using var context = new CoffeeShopDbContext();
            var fProduct = context.Products.SingleOrDefault(product => product.Id == id);
            if (fProduct is null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            context.Products.Remove(fProduct);
            context.SaveChanges();
        }
        public void Update(int id, Product product)
        {
            using var context = new CoffeeShopDbContext();
            var fProduct = context.Products.SingleOrDefault(product => product.Id == id);
            if (fProduct is null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            fProduct.Code = product.Code;
            fProduct.Description = product.Description;
            fProduct.Price = product.Price;
            fProduct.Cost = product.Cost;
            fProduct.ProductCategoryId = product.ProductCategoryId;
            fProduct.ProductCategory = product.ProductCategory;
            fProduct.TransactionLines = product.TransactionLines;
            context.SaveChanges();
        }
        public Product? GetById(int id)
        {
            using var context = new CoffeeShopDbContext();
            var fProduct = context.Products.Include(product => product.ProductCategory).Where(product => product.Id == id).SingleOrDefault();
            return fProduct;
        }
        public List<Product> GetAll()
        {
            using var context = new CoffeeShopDbContext();
            var fProducts = context.Products.Include(product => product.ProductCategory).ToList();
            return fProducts;
        }
    }
}
