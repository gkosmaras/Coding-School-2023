using PetShop.Models;
using Microsoft.EntityFrameworkCore;
using PetShop.EF.Context;
using PetShop.Models.Enums;

namespace PetShop.EF.Repositories {

    public class PetFoodRepo : IEntityRepo<PetFood> {

        public IList<PetFood> GetAll() {
            using var context = new PetShopDbContext();
            var dbPetFood = context.PetFoods.ToList();
            return dbPetFood;
        }

        public PetFood? GetById(int id) {
            using var context = new PetShopDbContext();
            var dbPetFood = context.PetFoods.Include(p => p.Transactions).SingleOrDefault(pf => pf.Id == id);
            return dbPetFood;
        }

        public void Add(PetFood petFood) {
            using var context = new PetShopDbContext();
            if (petFood.Id != 0) {
                throw new ArgumentException("Given entity should not have an ID set", nameof(petFood));
            }
            context.Add(petFood);
            context.SaveChanges();
        }

        public void Update(int id, PetFood petFood) {
            using var context = new PetShopDbContext();
            var dbPetFood = context.PetFoods.SingleOrDefault(pf => pf.Id == id);
            if (dbPetFood == null) {
                throw new KeyNotFoundException($"Giver ID '{id}' was not found in the database");
            }
            dbPetFood.AnimalType = petFood.AnimalType;
            dbPetFood.Price = petFood.Price;
            dbPetFood.Cost = petFood.Cost;
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new PetShopDbContext();
            var dbPetFood = context.PetFoods.SingleOrDefault(pf => pf.Id == id);
            if (dbPetFood == null) {
                throw new KeyNotFoundException($"Giver ID '{id}' was not found in the database");
            }
            context.Remove(dbPetFood);
            context.SaveChanges();
        }

    }

}