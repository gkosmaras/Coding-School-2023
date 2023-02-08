using CoffeeShop.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.EF.Context;
using CoffeeShop.Model;

namespace CoffeeShop.EF.Repositories
{
    public class TransactionLineRepo : IEntityRepo<TransactionLine>
    {
        public void Create(TransactionLine transLine)
        {
            using var context = new CoffeeShopDbContext();
            if (transLine.Id != 0)
            {
                throw new ArgumentException("Given transaction line should not have an ID set", nameof(transactionLine));
            }
            context.TransactionLines.Add(transLine);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            using var context = new CoffeeShopDbContext();
            var fTransLine = context.TransactionLines.SingleOrDefault(transLine => transLine.Id == id);
            if (fTransLine is null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            context.TransactionLines.Remove(fTransLine);
            context.SaveChanges();
        }
        public void Update(int id, TransactionLine transLine)
        {
            using var context = new CoffeeShopDbContext();
            var fTransLine = context.TransactionLines.SingleOrDefault(transLine => transLine.Id == id);
            if (fTransLine is null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            fTransLine.Quantity = transLine.Quantity;
            fTransLine.Discount = transLine.Discount;
            fTransLine.Price = transLine.Price;
            fTransLine.TotalPrice = transLine.TotalPrice;
            fTransLine.TransactionId = transLine.TransactionId;
            fTransLine.ProductId = transLine.ProductId;
            fTransLine.Product = transLine.Product;
            context.SaveChanges();
        }
        public TransactionLine? GetById (int id)
        {
            using var context = new CoffeeShopDbContext();
            var fTransLine = context.TransactionLines.Where(transLine => transLine.Id == id).SingleOrDefault();
            return fTransLine;
        }
        public List<TransactionLine> GetAll()
        {
            using var context = new CoffeeShopDbContext();
            var fTransLine = context.TransactionLines.ToList();
            return fTransLine;
        }
    }
}
