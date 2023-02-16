using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using PetShop.Blazor.Shared.DTO.Ledgers;
using PetShop.EF.Repositories;
using PetShop.Models;
using PetShop.Models.Enums;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                    Month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(ledge.First().Date.Month),
                    AnimalTypes = animalTypes,
                    Bird = ledge.Count(x => x.Pet.AnimalType == AnimalType.Bird),
                    Mammal = ledge.Count(x => x.Pet.AnimalType == AnimalType.Mammal),
                    Reptile = ledge.Count(x => x.Pet.AnimalType == AnimalType.Reptile),
                    Fish= ledge.Count(x => x.Pet.AnimalType == AnimalType.Fish)
                });

            return result;
        }
    }
}
