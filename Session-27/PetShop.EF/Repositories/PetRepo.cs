using PetShop.Models;
using Microsoft.EntityFrameworkCore;
using PetShop.EF.Context;

namespace PetShop.EF.Repositories {

    public class PetRepo : IEntityRepo<Pet> {

        public IList<Pet> GetAll() {
            using var context = new PetShopDbContext();
            var dbPet = context.Pets.ToList();
            return dbPet;
        }

        public Pet? GetById(int id) {
            using var context = new PetShopDbContext();
            var dbPet = context.Pets.Include(p => p.Transactions).SingleOrDefault(p => p.Id == id);
            return dbPet;
        }

        public void Add(Pet pet) {
            using var context = new PetShopDbContext();
            if (pet.Id != 0) {
                throw new ArgumentException("Given entity should not have an ID set", nameof(pet));
            }
            context.Add(pet);
            context.SaveChanges();
        }

        public void Update(int id, Pet pet) {
            using var context = new PetShopDbContext();
            var dbPet = context.Pets.SingleOrDefault(p => p.Id == id);
            if (dbPet == null) {
                throw new KeyNotFoundException($"Giver ID '{id}' was not found in the database");
            }
            dbPet.Breed = pet.Breed;
            dbPet.AnimalType = pet.AnimalType;
            dbPet.PetStatus = pet.PetStatus;
            dbPet.Price = pet.Price;
            dbPet.Cost = pet.Cost;
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new PetShopDbContext();
            var dbPet = context.Pets.SingleOrDefault(p => p.Id == id);
            if (dbPet == null) {
                throw new KeyNotFoundException($"Giver ID '{id}' was not found in the database");
            }
            context.Remove(dbPet);
            context.SaveChanges();
        }

    }

}