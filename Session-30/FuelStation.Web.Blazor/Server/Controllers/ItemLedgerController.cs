using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Model.Enums;
using FuelStation.Model.Transactions;
using FuelStation.Web.Blazor.Shared.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Linq;

namespace FuelStation.Web.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ItemLedgerController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<TransactionLine> _transLineRepo;
        private readonly IEntityRepo<Item> _itemRepo;

        public ItemLedgerController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<TransactionLine> transLineRepo, IEntityRepo<Item> itemRepo)
        {
            _transactionRepo = transactionRepo;
            _transLineRepo = transLineRepo;
            _itemRepo = itemRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<ItemLedgerDto>> Get()
        {
            var dbTransactions = _transactionRepo.GetAll();
            foreach (var date in dbTransactions)
            {
                date.Date = new DateTime(date.Date.Year, date.Date.Month, 1);
            }
            var itemTypes = Enum.GetNames(typeof(ItemType)).ToList();
            var result = dbTransactions.GroupBy(x => x.Date)
                .Select(ledge => new ItemLedgerDto
                {
                    Year = ledge.First().Date.Year,
                    Month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(ledge.First().Date.Month),
                    ItemNames = itemTypes,
                    ItemQnt = GetQuantity(ledge)
                });
            return result;
        }

        private List<int> GetQuantity(IGrouping<DateTime, Transaction> ledge)
        {
            List<int> result = new List<int>( new int[3]);
            var itemTypes = Enum.GetNames(typeof(ItemType)).ToList();
            var dbItem = _itemRepo.GetAll();
            foreach (var value in ledge)
            {
                var ids = value.TransactionLines.Select(x => x.ItemID).ToList();
                var qnt = value.TransactionLines.Select(x => x.Quantity).ToList();
                for (int i = 0; i < ids.Count; i++)
                {
                    switch (dbItem.SingleOrDefault(x => x.ID == ids[i]).ItemType)
                    {
                        case (ItemType)1:
                            result[0] += qnt[i];
                            break;
                        case (ItemType)2:
                            result[1] += qnt[i];
                            break;
                        case (ItemType)3:
                            result[2] += qnt[i];
                            break;
                    } 
                }
            }
            return result;
        }
    }
}
