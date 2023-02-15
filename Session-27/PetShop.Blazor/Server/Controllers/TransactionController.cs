using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Models;
using PetShop.Models.Enums;
using PetShop.Blazor.Shared.DTO.Transaction;
using PetShop.Blazor.Shared.DTO.Customer;
using PetShop.Blazor.Shared.DTO.Employee;
using PetShop.Blazor.Shared.DTO.Pet;
using PetShop.Blazor.Shared.DTO.PetFood;

namespace PetShop.Blazor.Server.Controllers
{

    [Route("[controller]")]
    [ApiController]

    public class TransactionController : ControllerBase
    {

        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Employee> _employeerRepo;
        private readonly IEntityRepo<Pet> _petRepo;
        private readonly IEntityRepo<PetFood> _petFoodRepo;
        public TransactionController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Employee> employeerRepo, IEntityRepo<Pet> petRepo, IEntityRepo<PetFood> petFoodRepo)
        {
            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _employeerRepo = employeerRepo;
            _petRepo = petRepo;
            _petFoodRepo = petFoodRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionDto>> Get()
        {

            var response = _transactionRepo.GetAll();

            return response.Select(Transaction => new TransactionDto
            {
                Date = Transaction.Date,
                PetPrice = Transaction.Pet.Price,
                PetFoodQty = Transaction.PetFoodQty,
                PetFoodPrice = Transaction.PetFood.Price,
                TotalPrice = Transaction.TotalPrice,

            });

        }
        [HttpGet("{id}")]
        public TransactionEditDto GetById(int id)
        {
            var dbTransaction = _transactionRepo.GetById(id);
            var dbCustomer = _customerRepo.GetAll();
            var dbEmployee = _employeerRepo.GetAll();
            var dbPet = _petRepo.GetAll();
            var dbPetFood = _petFoodRepo.GetAll();
            var result = new TransactionEditDto
            {
                Date = DateTime.Now,
                Id = dbTransaction.Id,
                CustomerId = dbTransaction.CustomerId,
                Customers = dbCustomer.Select(cus => new CustomerDto
                {
                    Id = cus.Id,
                    Name = cus.Name,
                }).ToList(),
                EmployeeId = dbTransaction.EmployeeId,
                Employees = dbEmployee.Select(ee => new EmployeeDto
                {
                    Id = ee.Id,
                    Name = ee.Name,
                }).ToList(),
                Pets = dbPet.Select(pet => new PetDto
                {
                    Id = pet.Id,
                    Breed = pet.Breed
                }).ToList(),
                PetFoods = dbPetFood.Select(petFood => new PetFoodDto
                {
                    Id = petFood.Id,
                    AnimalType = petFood.AnimalType,
                }).ToList()
            };
            return result;
        }

        [HttpPost]
        public async Task Post(TransactionEditDto transaction)
        {
            var temp = Convert.ToDecimal(transaction.Pets.Sum(x => x.Price));
            var temp1 = transaction.PetFoodQty;
            var temp2 = (transaction.PetFoodQty) * transaction.PetFoods.Sum(x => x.Price);
            var trans = new Transaction(temp, temp1, temp2, temp1 + temp2);
            trans.CustomerId = transaction.CustomerId;
            trans.EmployeeId = transaction.EmployeeId;
            trans.PetId = transaction.PetId;
            trans.PetFoodId = transaction.PetFoodId;
            _transactionRepo.Add(trans);
        }

        [HttpPut]
        public async Task Put(TransactionEditDto transaction)
        {
            var dbTransaction = _transactionRepo.GetById(transaction.Id);
            dbTransaction.PetFoodQty = transaction.PetFoodQty;
            dbTransaction.CustomerId = transaction.CustomerId;
            dbTransaction.EmployeeId = transaction.EmployeeId;
            dbTransaction.PetId = transaction.PetId;
            dbTransaction.PetFoodId = transaction.PetFoodId;
            _transactionRepo.Update(transaction.Id, dbTransaction);
        }
    }
}