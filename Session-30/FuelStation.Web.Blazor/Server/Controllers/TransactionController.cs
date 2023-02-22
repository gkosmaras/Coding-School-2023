using FuelStation.EF.Repositories;
using FuelStation.Model.Enums;
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
            var dbTransaction = _transactionRepo.GetAll();

            var result = dbTransaction.Select(trans => new TransactionEditDto
            {
                ID = trans.ID,
                Date= trans.Date,
                CustomerID = trans.CustomerID,
                EmployeeID = trans.EmployeeID,
                TotalValue = trans.TransactionLines.Sum(x => x.TotalValue),
                PaymentMethod = trans.PaymentMethod,
            });
            return result;
        }

        [HttpGet("{id}")]
        public async Task<TransactionEditDto> GetById(int id)
        {
            var dbTransaction = _transactionRepo.GetById(id);

            if (dbTransaction == null)
            {
                throw new ArgumentNullException();
            }

            var result = new TransactionEditDto
            {
                Date = dbTransaction.Date,
                CustomerID = dbTransaction.CustomerID,
                EmployeeID = dbTransaction.EmployeeID,
                TotalValue = dbTransaction.TransactionLines.Sum(x => x.TotalValue),
                PaymentMethod = dbTransaction.PaymentMethod,
                TransactionLines = dbTransaction.TransactionLines
            };
            return result;
        }

        [HttpPost]
        public async Task Post(TransactionEditDto transaction)
        {
            Transaction trans = new()
            {
                CustomerID = transaction.CustomerID,
                EmployeeID = transaction.EmployeeID,
                PaymentMethod = transaction.PaymentMethod,
                TotalValue = transaction.TransactionLines.Sum(x => x.TotalValue)
            };

            _transactionRepo.Add(trans);
        }

        [HttpPut]
        public async Task Put(TransactionEditDto transaction)
        {
            var dbTransaction = _transactionRepo.GetById(transaction.ID);
            if (dbTransaction == null)
            {
                throw new ArgumentNullException();
            }
            dbTransaction.CustomerID = transaction.CustomerID;
            dbTransaction.EmployeeID = transaction.EmployeeID;
            dbTransaction.PaymentMethod = transaction.PaymentMethod;
            dbTransaction.TotalValue = transaction.TransactionLines.Sum(x => x.TotalValue);
            _transactionRepo.Update(transaction.ID, dbTransaction);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _transactionRepo.Delete(id);
        }
    }
}
