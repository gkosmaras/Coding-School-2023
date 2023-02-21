using FuelStation.EF.Repositories;
using FuelStation.Model.Transactions;
using FuelStation.Web.Blazor.Shared.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Web.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;

        public TransactionController(IEntityRepo<Transaction> transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionEditDto>> Get()
        {
            var dbTransLine = _transactionRepo.GetAll();

            var result = dbTransLine.Select(trans => new TransactionEditDto
            {
                Date= trans.Date,
                CustomerID = trans.CustomerID,
                EmployeeID = trans.EmployeeID,
                TotalValue = trans.TotalValue,
                PaymentMethod = trans.PaymentMethod,
            });
            return result;
        }
    }
}
