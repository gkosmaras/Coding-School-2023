using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Models;
using PetShop.Blazor.Shared.DTO.PetFood;

namespace PetShop.Blazor.Server.Controllers {

    [Route("[controller]")]
    [ApiController]

    public class PetFoodController : ControllerBase {

        private readonly IEntityRepo<PetFood> _petFoodRepo;

        public PetFoodController(IEntityRepo<PetFood> petFoodRepo) {
            _petFoodRepo = petFoodRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<PetFoodDto>> Get() {

            var dbPetFood = _petFoodRepo.GetAll();

            var result = dbPetFood.Select(petFood => new PetFoodDto {
                Id = petFood.Id,
                AnimalType = petFood.AnimalType,
                Price = petFood.Price,
                Cost = petFood.Cost
            });

            return result;

        }

        [HttpGet("{id}")]
        public async Task<PetFoodEditDto> GetById(int id) {

            var dbPetFood = _petFoodRepo.GetById(id);

            if (dbPetFood == null) {
                throw new ArgumentNullException();
            }

            var result = new PetFoodEditDto {
                Id = id,
                AnimalType = dbPetFood.AnimalType,
                Price = dbPetFood.Price,
                Cost = dbPetFood.Cost
            };

            return result;

        }

        [HttpPost]
        public async Task Post(PetFoodEditDto petFood) {

            var dbPetFood = new PetFood(
                petFood.AnimalType,
                petFood.Price,
                petFood.Cost
                );

            _petFoodRepo.Add(dbPetFood);

        }

        [HttpPut]
        public async Task Put(PetFoodEditDto petFood) {

            var dbPetFood = _petFoodRepo.GetById(petFood.Id);

            if (dbPetFood == null) {
                throw new ArgumentNullException();
            }

            dbPetFood.AnimalType = petFood.AnimalType;
            dbPetFood.Price = petFood.Price;
            dbPetFood.Cost = petFood.Cost;

            _petFoodRepo.Update(petFood.Id, dbPetFood);

        }

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            _petFoodRepo.Delete(id);
        }

    }

}