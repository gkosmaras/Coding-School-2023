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
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        public void Create(Transaction transaction)
        {
            using var context = new CoffeeShopDbContext();
            if (transaction.Id != 0)
            {
                throw new ArgumentException("Given transaction should not have an ID set", nameof(transaction));
            }
            context.Transactions.Add(transaction);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            using var context = new CoffeeShopDbContext();
            var fTrans = context.Transactions.SingleOrDefault(transaction => transaction.Id == id);
            if (fTrans is null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            context.Transactions.Remove(fTrans);
            context.SaveChanges();
        }
        public void Update(int id, Transaction transaction)
        {
            using var context = new CoffeeShopDbContext();
            var fTrans = context.Transactions.SingleOrDefault(transaction => transaction.Id == id);
            if (fTrans is null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            fTrans.Date = transaction.Date;
            fTrans.TotalPrice = transaction.TotalPrice;
            fTrans.PaymentMethod = transaction.PaymentMethod;
            fTrans.CustomerId = transaction.CustomerId;
            fTrans.Customer = transaction.Customer;
            fTrans.EmployeeId = transaction.EmployeeId;
            fTrans.Employee = transaction.Employee;
            fTrans.TransactionLines = transaction.TransactionLines;
            context.SaveChanges();
        }
        public Transaction? GetById(int id)
        {
            using var context = new CoffeeShopDbContext();
            var fTrans = context.Transactions.Include(trans => trans.Customer).Include(trans => trans.Employee).Include(trans => trans.TransactionLines).Where(transaction => transaction.Id == id).SingleOrDefault();
            return fTrans;
        }
        public List<Transaction> GetAll()
        {
            using var context = new CoffeeShopDbContext();
            var fTrans = context.Transactions.ToList();
            return fTrans;
        }
    }
}
