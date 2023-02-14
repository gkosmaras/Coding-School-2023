using Microsoft.EntityFrameworkCore;
using PetShop.EF.Context;
using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories
{
    public class PetFoodRepo : IEntityRepo<PetFood>
    {
        public void Add(PetFood petFood)
        {
            using var context = new PetShopDbContext();
            if (petFood.Id != 0)
            {
                throw new ArgumentException("Given entity should not have an ID set", nameof(petFood));
            }
            context.Add(petFood);
            context.SaveChanges();
        }
        public void Update(int id, PetFood petFood)
        {
            using var context = new PetShopDbContext();
            var dbPetFood = context.PetFoods.Where(pFood => pFood.Id == id).SingleOrDefault();
            if (dbPetFood == null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            dbPetFood.AnimalType = petFood.AnimalType;
            dbPetFood.Price = petFood.Price;
            dbPetFood.Cost = petFood.Cost;
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            using var context = new PetShopDbContext();
            var dbPetFood = context.PetFoods.Where(pFood => pFood.Id == id).SingleOrDefault();
            if (dbPetFood == null)
            {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }
            context.Remove(dbPetFood);
            context.SaveChanges();
        }
        public PetFood? GetById(int id)
        {
            using var context = new PetShopDbContext();
            var dbPetFood = context.PetFoods.Where(pFood => pFood.Id == id)
                .Include(pFood => pFood.Transactions).SingleOrDefault();
            return dbPetFood;
        }
        public IList<PetFood> GetAll()
        {
            using var context = new PetShopDbContext();
            var dbPetFood = context.PetFoods.Include(pFood => pFood.Transactions).ToList();
            return dbPetFood;
        }
    }
}
