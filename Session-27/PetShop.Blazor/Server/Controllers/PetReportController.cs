using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using PetShop.Blazor.Shared.DTO.Ledgers;
using PetShop.EF.Repositories;
using PetShop.Models;
using PetShop.Models.Enums;
using System.Globalization;

namespace PetShop.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PetReportController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        public PetReportController(IEntityRepo<Transaction> transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<PetReportDto>> Get()
        {
            var dbTransactions = _transactionRepo.GetAll();
            foreach (var date in dbTransactions)
            {
                date.Date = new DateTime(date.Date.Year, date.Date.Month, 1);
            }

            var animalTypes = Enum.GetNames(typeof(AnimalType)).ToList();
            List<AnimalType> typesEnum = Enum.GetValues(typeof(AnimalType)).Cast<AnimalType>().ToList();
            var sold = new List<int>();
            var result = dbTransactions.GroupBy(x => x.Date)
                .Select(ledge => new PetReportDto
                {
                    Year = ledge.First().Date.Year,
                    Month = ledge.First().Date.Month, //CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(ledge.First().Date.Month),
                    AnimalTypes = animalTypes
                    

                });
            foreach (var date in result)
            {
                sold.Clear();
                foreach (var animal in typesEnum)
                {
                    sold.Add(dbTransactions.Where(d => d.Date.Year == date.Year & d.Date.Month == date.Month).Count(x => x.Pet.AnimalType == animal));
                }
                date.TotalSold.Add(sold);
            }
            return result;
        }
    }
}
