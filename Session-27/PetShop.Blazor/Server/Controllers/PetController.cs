using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Models;
using PetShop.Blazor.Shared.DTO.Pet;

namespace PetShop.Blazor.Server.Controllers {

    [Route("[controller]")]
    [ApiController]

    public class PetController : ControllerBase {

        private readonly IEntityRepo<Pet> _petRepo;

        public PetController(IEntityRepo<Pet> petRepo) {
            _petRepo = petRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<PetDto>> Get() {
            var response = _petRepo.GetAll();

            return response.Select(pet => new PetDto {
                Id = pet.Id,
                Breed = pet.Breed,
                AnimalType = pet.AnimalType,
                PetStatus = pet.PetStatus,
                Price = pet.Price,
                Cost = pet.Cost
            });

        }

        [HttpGet("{id}")]
        public async Task<PetEditDto> GetById(int id) {

            var dbPet = _petRepo.GetById(id);

            if (dbPet == null) {
                throw new ArgumentNullException();
            }

            var result = new PetEditDto {
                Id = id,
                Breed = dbPet.Breed,
                AnimalType = dbPet.AnimalType,
                PetStatus = dbPet.PetStatus,
                Price = dbPet.Price,
                Cost = dbPet.Cost
            };

            return result;

        }

        [HttpPost]
        public async Task Post(PetEditDto pet) {
            var dbPet = new Pet(
                pet.Breed,
                pet.AnimalType,
                pet.PetStatus,
                pet.Price,
                pet.Cost
                );
            _petRepo.Add(dbPet);
        }

        [HttpPut]
        public async Task Put(PetEditDto pet) {

            var dbPet = _petRepo.GetById(pet.Id);

            if (dbPet == null) {
                throw new ArgumentNullException();
            }

            dbPet.Breed = pet.Breed;
            dbPet.AnimalType = pet.AnimalType;
            dbPet.PetStatus = pet.PetStatus;
            dbPet.Price = pet.Price;
            dbPet.Cost = pet.Cost;

            _petRepo.Update(pet.Id, dbPet);

        }

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            _petRepo.Delete(id);
        }

    }

}