using CoffeeShop.Model;
using CoffeeShop.Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Orm.Repositories
{
    public class ProductRepository : IEntityRepository<Product>
    {
        public void Add(Product ent)
        {
            using var context = new AddDbContext();
            context.Products.Add(ent);
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            using var context = new AddDbContext();
            var tempPro = context.Products.SingleOrDefault(prod => prod.ID == id);
            if (tempPro is null)
                return;
            context.Products.Remove(tempPro);
            context.SaveChanges();
        }

        public List<Product> GetAll()
        {
            using var context = new AddDbContext();
            return context.Products.ToList();
        }

        public Product? GetById(Guid id)
        {
            using var context = new AddDbContext();
            return context.Products.Where(prod => prod.ID == id).SingleOrDefault();
        }

        public void Update(Guid id, Product ent)
        {
            using var context = new AddDbContext();
            var tempPro = context.Products.SingleOrDefault(prod => prod.ID == id);
            if (tempPro is null)
                return;
            tempPro.Cost = ent.Cost;
            tempPro.Code = ent.Code;
            tempPro.Price = ent.Price;
            tempPro.Description = ent.Description;
            tempPro.ProductCategory = ent.ProductCategory;
            context.SaveChanges();
        }
    }
}

