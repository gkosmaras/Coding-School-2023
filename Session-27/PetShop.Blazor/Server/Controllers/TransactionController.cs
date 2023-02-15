using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Models;
using PetShop.Models.Enums;
using PetShop.Blazor.Shared.DTO.Transaction;

namespace PetShop.Blazor.Server.Controllers {

    [Route("[controller]")]
    [ApiController]

    public class TransactionController : ControllerBase {

        private readonly IEntityRepo<Transaction> _transactionRepo;

        public TransactionController(IEntityRepo<Transaction> transactionRepo) {
            _transactionRepo = transactionRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionDto>> Get() {

            var transactions = _transactionRepo.GetAll();

            return transactions.Select(transaction => new TransactionDto {
                Id = transaction.Id,
                Date = transaction.Date,
                PetPrice = transaction.PetPrice,
                PetFoodQty = transaction.PetFoodQty,
                PetFoodPrice = transaction.PetFoodPrice,
                TotalPrice = transaction.TotalPrice,
                // Relations
                CustomerId = transaction.Customer.Id,
                EmployeeId = transaction.Employee.Id,
                PetId = transaction.Pet.Id,
                PetFoodId = transaction.PetFood.Id   
            });

        }

    }

}