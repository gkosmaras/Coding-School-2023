using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Orm.Context;

/*namespace CoffeeShop.Orm.Repositories
{
    public class ProductCategoryRepository : IEntityRepository<ProductCategory>
    {
        public void Add(ProductCategory ent)
        {
            using var context = new AddDbContext();
            context.ProductCategories.Add(ent);
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            using var context = new AddDbContext();
            var tempProdCat = context.ProductCategories.SingleOrDefault(prodCat => prodCat.ID == id);
            if (tempProdCat is null)
                return;
            context.ProductCategories.Remove(tempProdCat);
            context.SaveChanges();
        }

        public List<ProductCategory> GetAll()
        {
            using var context = new AddDbContext();
            return context.ProductCategories.ToList();
        }

        public ProductCategory? GetById(Guid id)
        {
            using var context = new AddDbContext();
            return context.ProductCategories.Where(prodCat => prodCat.ID == id).SingleOrDefault();
        }

        public void Update(Guid id, ProductCategory ent)
        {
            using var context = new AddDbContext();
            var tempProdCat = context.ProductCategories.SingleOrDefault(prodCat => prodCat.ID == id);
            if (tempProdCat is null)
                return;
            tempProdCat.Code = ent.Code;
            tempProdCat.Description = ent.Description;
            tempProdCat.ProductType = ent.ProductType;
            context.SaveChanges();
        }
    }
}*/
