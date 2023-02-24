using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Model.People;
using FuelStation.Model.Transactions;
using FuelStation.Web.Blazor.Shared.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;
using System.Globalization;

namespace FuelStation.Web.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MonthlyLedgerController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<TransactionLine> _transLineRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Item> _itemRepo;

        public MonthlyLedgerController(IEntityRepo<TransactionLine> transLineRepo, IEntityRepo<Employee> employeeRepo, IEntityRepo<Transaction> transactionRepo, IEntityRepo<Item> itemRepo)
        {
            _itemRepo = itemRepo;
            _transactionRepo = transactionRepo;
            _transLineRepo = transLineRepo;
            _employeeRepo = employeeRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<MonthlyLedgerDto>> Get()
        {
            var dbTransaction = _transactionRepo.GetAll();
            foreach (var date in dbTransaction)
            {
                date.Date = new DateTime(date.Date.Year, date.Date.Month, 1);
            }
            var result = dbTransaction.GroupBy(x => x.Date)
                .Select(ledge => new MonthlyLedgerDto
                {
                    Year = ledge.First().Date.Year,
                    Month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(ledge.First().Date.Month),
                    Income = ledge.SelectMany(x => x.TransactionLines).Sum(it => (it.TotalValue)),
                    Expenses = GetExpenses(ledge), //ledge.SelectMany(x => x.TransactionLines).Sum(it => (it.Item.Cost)),
                    Total = 0
                });
            return result;
        }

        private decimal GetExpenses(IGrouping<DateTime, Transaction> ledge)
        {
            var dbItem = _itemRepo.GetAll();
            decimal total = 0;
            foreach (var value in ledge)
            {
                var ids = value.TransactionLines.Select(x => x.ItemID).ToList();
                var qnt = value.TransactionLines.Select(x => x.Quantity).ToList();
                for (int i = 0; i < ids.Count(); i++)
                {
                    total = dbItem.SingleOrDefault(it => it.ID == ids[i]).Cost * qnt[i];
                }
            }
            return total;
            
        }
    }
}
