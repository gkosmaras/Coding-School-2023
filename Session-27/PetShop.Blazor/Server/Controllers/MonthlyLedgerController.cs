using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using PetShop.Blazor.Shared.DTO.Ledgers;
using PetShop.EF.Repositories;
using PetShop.Models;

namespace PetShop.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MonthlyLedgerController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        public MonthlyLedgerController(IEntityRepo<Transaction> transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<MonthlyLedgerDto>> Get()
        {
            var dbTransactions = _transactionRepo.GetAll();
            foreach(var date in dbTransactions)
            {
                date.Date = new DateTime(date.Date.Year, date.Date.Month, 1);
            }
            /*            List<MonthlyLedgerDto> result = dbTransactions
                            .GroupBy(d => d.Date)
                            .SelectMany(l => l.Select(
                                ledge => new MonthlyLedgerDto
                                {
                                    Date = ledge.Date,
                                    Income = l.Sum(x => x.TotalPrice)
                                })).ToList();*/
            var result = dbTransactions.GroupBy(x => x.Date)
                .Select(ledge => new MonthlyLedgerDto
                {
                    Date = ledge.First().Date,
                    Income = ledge.Sum(x => x.TotalPrice)
                });
            return result;
        }
    }
}
