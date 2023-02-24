using FuelStation.EF.Context;
using FuelStation.Model.People;
using FuelStation.Model.Transactions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories
{
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        public IList<Transaction> GetAll()
        {
            using var context = new FuelStationDbContext();
            var dbTrans = context.Transactions
                .Include(trans => trans.Employee)
                .Include(trans => trans.Customer)
                .Include(trans => trans.TransactionLines)
                .ToList();
            return dbTrans;
        }

        public Transaction? GetById(int id)
        {
            using var context = new FuelStationDbContext();
            var dbTrans = context.Transactions
                .Include(trans => trans.Employee)
                .Include(trans => trans.Customer)
                .Include(trans => trans.TransactionLines)
                .SingleOrDefault(trans => trans.ID == id);
            return dbTrans;
        }

        public void Add(Transaction transaction)
        {
            if (transaction.ID != 0)
            {
                throw new ArgumentException("Given entity should not have an ID set", nameof(transaction));
            }
            using var context = new FuelStationDbContext();
            context.Add(transaction);
            context.SaveChanges();
        }

        public void Update(int id, Transaction transaction)
        {
            using var context = new FuelStationDbContext();
            var dbTrans = context.Transactions.
                Include(trans => trans.Employee)
                .Include(trans => trans.Customer)
                .Include(trans => trans.TransactionLines)
                .SingleOrDefault(trans => trans.ID == id);
            if (dbTrans == null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            dbTrans.EmployeeID = transaction.EmployeeID;
            dbTrans.CustomerID = transaction.CustomerID;
            dbTrans.PaymentMethod = transaction.PaymentMethod;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new FuelStationDbContext();
            var dbTrans = context.Transactions
                .SingleOrDefault(trans => trans.ID == id);
            if (dbTrans == null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            context.Remove(dbTrans);
            context.SaveChanges();
        }
    }
}
