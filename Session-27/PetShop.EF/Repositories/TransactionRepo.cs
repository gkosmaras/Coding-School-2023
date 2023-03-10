using Microsoft.EntityFrameworkCore;
using PetShop.EF.Context;
using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories {

    public class TransactionRepo : IEntityRepo<Transaction> {

        public IList<Transaction> GetAll() {
            using var context = new PetShopDbContext();
            var dbTransaction = context.Transactions
                .Include(tr => tr.Customer)
                .Include(tr => tr.Employee)
                .Include(tr => tr.Pet)
                .Include(tr => tr.PetFood)
                .ToList();
            return dbTransaction;
        }

        public Transaction? GetById(int id) {
            using var context = new PetShopDbContext();
            var dbTransaction = context.Transactions
                .Where(tr => tr.Id == id)
                .Include(tr => tr.Customer)
                .Include(tr => tr.Employee)
                .Include(tr => tr.Pet)
                .Include(tr => tr.PetFood)
                .SingleOrDefault();
            return dbTransaction;
        }

        public void Add(Transaction transaction) {
            using var context = new PetShopDbContext();
            if (transaction.Id != 0) {
                throw new ArgumentException("Given entity should not have an ID set", nameof(transaction));
            }
            context.Add(transaction);
            context.SaveChanges();
        }

        public void Update(int id, Transaction transaction) {
            using var context = new PetShopDbContext();
            var dbTransaction = context.Transactions.
                Where(tr => tr.Id == id)
                .SingleOrDefault();
            if (dbTransaction == null) {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            dbTransaction.Date = transaction.Date;
            dbTransaction.PetPrice = transaction.PetPrice;
            dbTransaction.PetFoodQty = transaction.PetFoodQty;
            dbTransaction.PetFoodPrice = transaction.PetFoodPrice;
            dbTransaction.TotalPrice = transaction.TotalPrice;
            dbTransaction.CustomerId = transaction.CustomerId;
            dbTransaction.EmployeeId = transaction.EmployeeId;
            dbTransaction.PetId= transaction.PetId;
            dbTransaction.PetFoodId = transaction.PetFoodId;
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new PetShopDbContext();
            var dbTransaction = context.Transactions
                .Where(tr => tr.Id == id)
                .SingleOrDefault();
            if (dbTransaction == null) {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            context.Remove(dbTransaction);
            context.SaveChanges();
        }  

    }

}

