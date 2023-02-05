using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Model;
using CoffeeShop.Orm.Context;

namespace CoffeeShop.Orm.Repositories
{
/*    public class TransactionRepository : IEntityRepository<Transaction>
    {
        public void Add(Transaction ent)
        {
            using var context = new AddDbContext();
            context.Transactions.Add(ent);
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            using var context = new AddDbContext();
            var tempTrans = context.Transactions.SingleOrDefault(trans => trans.ID == id);
            if (tempTrans is null)
                return;

            context.Transactions.Remove(tempTrans);
            context.SaveChanges();
        }

        public List<Transaction> GetAll()
        {
            using var context = new AddDbContext();
            return context.Transactions.ToList();
        }
        public Transaction? GetById(Guid id)
        {
            using var context = new AddDbContext();
            return context.Transactions.Where(trans => trans.ID == id).SingleOrDefault(); ;
        }

        public void Update(Guid id, Transaction ent)
        {
            using var context = new AddDbContext();
            var tempTrans = context.Transactions.SingleOrDefault(trans => trans.ID == id);
            if (tempTrans is null)
                return;
            tempTrans.Date = ent.Date;
            tempTrans.EmployeeID = ent.EmployeeID;
            tempTrans.CustomerID = ent.CustomerID;
            tempTrans.TransactionLines = ent.TransactionLines;
            tempTrans.TypeOfPayment = ent.TypeOfPayment;
            tempTrans.TotalPrice = ent.TotalPrice;
            tempTrans.Cost = ent.Cost;
            context.SaveChanges();
        }
    }*/
}
