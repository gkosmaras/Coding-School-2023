using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using PetShop.EF.Context;
using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories
{
    public class PetRepo : IEntityRepo<Pet>
    {
        public void Add(Pet pet)
        {
            using var context = new PetShopDbContext();
            if (pet.Id != null)
            {
                throw new ArgumentException("Given entity should not have an ID set", nameof(pet));
            }
            context.Add(pet);
            context.SaveChanges();
        }
        public void Update(int id, Pet pet)
        {
            using var context = new PetShopDbContext();
            var dbPet = context.Pets.Where(p => p.Id == id).SingleOrDefault();
            if (pet.Id == 0)
            {
                throw new KeyNotFoundException($"Giver ID '{id}' was not found in the database");
            }
            dbPet.Breed = pet.Breed;
            dbPet.AnimalType = pet.AnimalType;
            dbPet.PetStatus = pet.PetStatus;
            dbPet.Price = pet.Price;
            dbPet.Cost = pet.Cost;
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            using var context = new PetShopDbContext();
            var dbPet = context.Pets.Where(p =>p.Id == id).SingleOrDefault();
            if (dbPet.Id == 0)
            {
                throw new KeyNotFoundException($"Giver ID '{id}' was not found in the database");
            }
            context.Remove(dbPet);
        }
        public Pet? GetById(int id)
        {
            using var context = new PetShopDbContext();
            var dbPet = context.Pets.Include(p => p.Transactions).Where(p => p.Id == id).SingleOrDefault();
            return dbPet;
        }
        public IList<Pet> GetAll()
        {
            using var context = new PetShopDbContext();
            var dbPet = context.Pets.Include(p => p.Transactions).ToList();
            return dbPet;
        }
    }
}
