using FuelStation.EF.Context;
using FuelStation.Model;
using FuelStation.Model.People;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories
{
    public  class ItemRepo : IEntityRepo<Item>
    {

        public IList<Item> GetAll()
        {
            using var context = new FuelStationDbContext();
            var dbItem = context.Items
                .Include(it => it.TransactionLines)
                .ToList();
            return dbItem;
        }

        public Item? GetById(Guid id)
        {
            using var context = new FuelStationDbContext();
            var dbItem = context.Items
                .Include(it => it.TransactionLines)
                .SingleOrDefault(it => it.ID == id);
            return dbItem;
        }

        public void Add(Item item)
        {
            if (item.ID != Guid.Empty)
            {
                throw new ArgumentException("Given entity should not have an ID set", nameof(item));
            }
            using var context = new FuelStationDbContext();
            context.Add(item);
            context.SaveChanges();
        }

        public void Update(Guid id, Item item)
        {
            using var context = new FuelStationDbContext();
            var dbItem = context.Items
                .Include(it => it.TransactionLines)
                .SingleOrDefault(it => it.ID == id);
            if (dbItem == null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            dbItem.Code = item.Code;
            dbItem.Description = item.Description;
            dbItem.ItemType = item.ItemType;
            dbItem.Price = item.Price;
            dbItem.Cost = item.Cost;
        }

        public void Delete(Guid id)
        {
            using var context = new FuelStationDbContext();
            var dbItem = context.Items
                .SingleOrDefault(it => it.ID == id);
            if (dbItem == null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            context.Remove(dbItem);
            context.SaveChanges();
        }
    }
}
