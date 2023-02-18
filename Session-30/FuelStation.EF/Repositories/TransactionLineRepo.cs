using FuelStation.EF.Context;
using FuelStation.Model.People;
using FuelStation.Model.Transactions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories
{
    public class TransactionLineRepo : IEntityRepo<TransactionLine>
    {

        public IList<TransactionLine> GetAll()
        {
            using var context = new FuelStationDbContext();
            var dbTransLine = context.TransactionLines
                .Include(transLine => transLine.Transaction)
                .Include(transLine => transLine.Item)
                .ToList();
            return dbTransLine;
        }

        public TransactionLine? GetById(int id)
        {
            using var context = new FuelStationDbContext();
            var dbTransLine = context.TransactionLines
                .Include(transLine => transLine.Transaction)
                .Include(transLine => transLine.Item)
                .SingleOrDefault(transLine => transLine.ID == id);
            return dbTransLine;
        }

        public void Add(TransactionLine transactionLine)
        {
            if (transactionLine.ID != 0)
            {
                throw new ArgumentException("Given entity should not have an ID set", nameof(transactionLine));
            }
            using var context = new FuelStationDbContext();
            context.Add(transactionLine);
            context.SaveChanges();
        }

        public void Update(int id, TransactionLine transactionLine)
        {
            using var context = new FuelStationDbContext();
            var dbTransLine = context.TransactionLines
                .Include(transLine => transLine.Transaction)
                .Include(transLine => transLine.Item)
                .SingleOrDefault(transLine => transLine.ID == id);
            if (dbTransLine == null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            dbTransLine.Quantity = transactionLine.Quantity;
            dbTransLine.ItemPrice = transactionLine.ItemPrice;
            dbTransLine.NetValue = transactionLine.NetValue;
            dbTransLine.DiscountPercent = transactionLine.DiscountPercent;
            dbTransLine.DiscountValue = transactionLine.DiscountValue;
            dbTransLine.TotalValue = transactionLine.TotalValue;
            dbTransLine.TransactionID = transactionLine.TransactionID;
            dbTransLine.ItemID = transactionLine.ItemID;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new FuelStationDbContext();
            var dbTransLine = context.TransactionLines
                .SingleOrDefault(transLine => transLine.ID == id);
            if (dbTransLine == null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            context.Remove(dbTransLine);
            context.SaveChanges();
        }
    }
}
