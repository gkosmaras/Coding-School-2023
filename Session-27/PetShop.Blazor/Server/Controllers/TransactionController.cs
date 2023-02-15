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

            var response = _transactionRepo.GetAll();

            return response.Select(Transaction => new TransactionDto {
                Id = Transaction.Id,
                Date = Transaction.Date,
                PetPrice = Transaction.PetPrice,
                PetFoodQty = Transaction.PetFoodQty,
                PetFoodPrice = Transaction.PetFoodPrice,
                TotalPrice = Transaction.TotalPrice      
            });

        }

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            _transactionRepo.Delete(id);
        }

    }

}