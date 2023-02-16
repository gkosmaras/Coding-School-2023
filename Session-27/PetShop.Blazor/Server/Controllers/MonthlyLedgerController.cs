using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using PetShop.Blazor.Client.Pages.Employee;
using PetShop.Blazor.Shared.DTO.Ledgers;
using PetShop.EF.Repositories;
using PetShop.Models;
using System.Globalization;

namespace PetShop.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MonthlyLedgerController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Models.Employee> _employeeRepo;
        public MonthlyLedgerController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Models.Employee> employeeRepo)
        {
            _transactionRepo = transactionRepo;
            _employeeRepo = employeeRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<MonthlyLedgerDto>> Get()
        {
            var dbTransactions = _transactionRepo.GetAll();
            var dbEmployee = _employeeRepo.GetAll();
            foreach(var date in dbTransactions)
            {
                date.Date = new DateTime(date.Date.Year, date.Date.Month, 1);
            }
            decimal wages = dbEmployee.Sum(x => x.SalaryPerMonth);
            decimal rent = 2000;
            var result = dbTransactions.GroupBy(x => x.Date)
                .Select(ledge => new MonthlyLedgerDto
                {
                    Year = ledge.First().Date.Year,
                    Month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(ledge.First().Date.Month),
                    Income = ledge.Sum(x => x.TotalPrice),
                    Expenses = wages + (ledge.Sum(x => x.PetFood.Cost * x.PetFoodQty)) + ledge.Sum(x => x.Pet.Cost),
                    Total = dbTransactions.Sum(x => x.TotalPrice) - (wages + rent + (ledge.Sum(x => x.PetFood.Cost * x.PetFoodQty)) + ledge.Sum(x => x.Pet.Cost))
                });
            return result;
        }
    }
}
