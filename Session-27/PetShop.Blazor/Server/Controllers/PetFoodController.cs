using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Models;
using PetShop.Models.Enums;
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

            var response = _petFoodRepo.GetAll();

            return response.Select(petFood => new PetFoodDto {
                Id = petFood.Id,
                AnimalType = petFood.AnimalType,
                Price = petFood.Price,
                Cost = petFood.Cost
            });

        }

        [HttpGet("{id}")]
        public async Task<PetFoodEditDto> GetById(int id) {

            var response = _petFoodRepo.GetById(id);

            return new PetFoodEditDto {
                Id = id,
                AnimalType = response.AnimalType,
                Price = response.Price,
                Cost = response.Cost
            };

        }

        [HttpPost]
        public async Task Post(PetFoodEditDto petFood) {
            var newPetFood = new PetFood(petFood.AnimalType, petFood.Price, petFood.Cost);
            _petFoodRepo.Add(newPetFood);
        }

        [HttpPut]
        public async Task Put(PetFoodEditDto petFood) {

            var itemToUpdate = _petFoodRepo.GetById(petFood.Id);

            itemToUpdate.AnimalType = petFood.AnimalType;
            itemToUpdate.Price = petFood.Price;
            itemToUpdate.Cost = petFood.Cost;

            _petFoodRepo.Update(petFood.Id, itemToUpdate);

        }

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            _petFoodRepo.Delete(id);
        }

    }

}