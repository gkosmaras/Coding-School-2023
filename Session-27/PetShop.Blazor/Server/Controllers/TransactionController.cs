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
using Microsoft.AspNetCore.Mvc.Infrastructure;

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

            var transactions = _transactionRepo.GetAll();

            var result = transactions.Select(Transaction => new TransactionDto
            {
                Id = Transaction.Id,
                Date = Transaction.Date,
                PetPrice = Transaction.Pet.Price,
                PetFoodQty = Transaction.PetFoodQty,
                PetFoodPrice = Transaction.PetFood.Price,
                TotalPrice = Transaction.TotalPrice,
                CustomerId = Transaction.Customer.Id,
                EmployeeId = Transaction.EmployeeId,
                PetId = Transaction.PetId,
                PetFoodId = Transaction.PetFoodId,
            });
            return result;
        }
        [HttpGet("{id}")]
        public async Task <TransactionEditDto> GetById(int id)
        {
            var dbTransaction = _transactionRepo.GetById(id);
            var dbCustomer = _customerRepo.GetAll();
            var dbEmployee = _employeerRepo.GetAll();
            var dbPet = _petRepo.GetAll();
            var dbPetFood = _petFoodRepo.GetAll();
            if (dbTransaction == null)
            {
                throw new ArgumentNullException();
            }
            var result = new TransactionEditDto
            {
                Date = DateTime.Now,
                Id = dbTransaction.Id,
                CustomerId = dbTransaction.CustomerId,
                Customers = dbCustomer.Select(cus => new CustomerEditDto
                {
                    Id = cus.Id,
                    Name = cus.Name,
                }).ToList(),
                EmployeeId = dbTransaction.EmployeeId,
                Employees = dbEmployee.Select(ee => new EmployeeEditDto
                {
                    Id = ee.Id,
                    Name = ee.Name,
                }).ToList(),
                Pets = dbPet.Select(pet => new PetEditDto
                {
                    Id = pet.Id,
                    Breed = pet.Breed
                }).ToList(),
                PetFoods = dbPetFood.Select(petFood => new PetFoodEditDto
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
            var pPrice = transaction.Pets.SingleOrDefault(x => x.Id == transaction.PetId).Price;
            var fQnt = transaction.PetFoodQty;
            var fPrice = (transaction.PetFoodQty) * transaction.PetFoods.SingleOrDefault(x => x.Id == transaction.PetFoodId).Price;

            var trans = new Transaction(pPrice, fQnt, fPrice, pPrice + fPrice);
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
            if (dbTransaction == null)
            {
                throw new ArgumentNullException();
            }
            var pPrice = transaction.Pets.SingleOrDefault(x => x.Id == transaction.PetId).Price;
            var fQnt = transaction.PetFoodQty;
            var fPrice = (transaction.PetFoodQty) * transaction.PetFoods.SingleOrDefault(x => x.Id == transaction.PetFoodId).Price;
            dbTransaction.PetPrice = pPrice;
            dbTransaction.PetFoodPrice = fPrice;
            dbTransaction.TotalPrice = pPrice + fPrice;
            dbTransaction.PetFoodQty = transaction.PetFoodQty;
            dbTransaction.CustomerId = transaction.CustomerId;
            dbTransaction.EmployeeId = transaction.EmployeeId;
            dbTransaction.PetId = transaction.PetId;
            dbTransaction.PetFoodId = transaction.PetFoodId;
            _transactionRepo.Update(transaction.Id, dbTransaction);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _transactionRepo.Delete(id);
        }
    }
}