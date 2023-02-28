using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Model.People;
using FuelStation.Model.Transactions;
using FuelStation.Web.Blazor.Shared;
using FuelStation.Web.Blazor.Shared.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;
using Syncfusion.Blazor.Inputs;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        private Serializer serial = new Serializer();

        public MonthlyLedgerController(IEntityRepo<TransactionLine> transLineRepo, IEntityRepo<Employee> employeeRepo, IEntityRepo<Transaction> transactionRepo, IEntityRepo<Item> itemRepo)
        {
            _itemRepo = itemRepo;
            _transactionRepo = transactionRepo;
            _transLineRepo = transLineRepo;
            _employeeRepo = employeeRepo;
        }
        // TODO: implement manger-set rent
        [HttpGet]
        public async Task<IEnumerable<MonthlyLedgerDto>> Get()
        {
            var dbTransaction = _transactionRepo.GetAll();
            List<Rent> rents = serial.DeserializeFromFile<List<Rent>>(@"..\Shared\rent.txt");
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
                    Expenses = GetExpenses(ledge) + GetWages(ledge) + rents.Last().monthlyRent,
                    Total = ledge.SelectMany(x => x.TransactionLines).Sum(it => (it.TotalValue)) - (GetExpenses(ledge) + GetWages(ledge) + rents.Last().monthlyRent)
                });
            return result;
        }

        [HttpPut]
        public async void UpdateRent(List<Rent> rents)
        {
            serial.SerializeToFile(rents, @"..\Shared\rent.txt");
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
                    total += dbItem.SingleOrDefault(it => it.ID == ids[i]).Cost * qnt[i];
                }
            }
            return total;
        }

        private decimal GetWages(IGrouping<DateTime, Transaction> ledge)
        {
            var dbEmployee = _employeeRepo.GetAll();
            decimal total = 0;
            foreach (var date in dbEmployee)
            {
                date.HireDateStart = new DateTime(date.HireDateStart.Year, date.HireDateStart.Month, 1);
                date.HireDateEnd = new DateTime(date.HireDateEnd.Year, date.HireDateEnd.Month, 1);
            }
            foreach (var ee in dbEmployee)
            {
                if ((DateTime.Compare(ledge.First().Date, ee.HireDateStart) >= 0) && (DateTime.Compare(ledge.First().Date, ee.HireDateEnd) <= 0))
                {
                    total += ee.SalaryPerMonth;
                }
            }
            return total;
        }
    }
}
