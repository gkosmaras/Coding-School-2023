using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Model.Enums;
using FuelStation.Model.Transactions;
using FuelStation.Web.Blazor.Shared.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Web.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransactionLineController : ControllerBase
    {
        private readonly IEntityRepo<TransactionLine> _transLineRepo;
        private readonly IEntityRepo<Item> _itemRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;

        public TransactionLineController(IEntityRepo<TransactionLine> transLineRepo, IEntityRepo<Item> itemRepo, IEntityRepo<Transaction> transactionRepo)
        {
            _transLineRepo = transLineRepo;
            _itemRepo = itemRepo;
            _transactionRepo = transactionRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionLineEditDto>> Get()
        {
            var dbTransLine = _transLineRepo.GetAll();

            var result = dbTransLine.Select(tLine => new TransactionLineEditDto
            {
                ID = tLine.ID,
                TransactionID = tLine.TransactionID,
                ItemID = tLine.ItemID,
                Quantity = tLine.Quantity,
                ItemPrice = tLine.ItemPrice,
                NetValue = tLine.NetValue,
                DiscountPercent = tLine.DiscountPercent,
                DiscountValue = tLine.DiscountValue,
                TotalValue = tLine.TotalValue,
            });
            return result;
        }

        [HttpGet("{id}")]
        public async Task<TransactionLineEditDto> GetById(int id)
        {
            var dbTransLine = _transLineRepo.GetById(id);

            if (dbTransLine == null)
            {
                throw new ArgumentNullException();
            }

            var result = new TransactionLineEditDto
            {
                ID = id,
                TransactionID = dbTransLine.TransactionID,
                ItemID = dbTransLine.ItemID,
                Quantity = dbTransLine.Quantity,
                ItemPrice = dbTransLine.ItemPrice,
                NetValue = dbTransLine.NetValue,
                DiscountPercent = dbTransLine.DiscountPercent,
                DiscountValue = dbTransLine.DiscountValue,
                TotalValue = dbTransLine.TotalValue
            };
            return result;
        }

        [HttpPost]
        public async Task Post(TransactionLineEditDto transLine)
        {
            decimal itemPrice = _itemRepo.GetById(transLine.ItemID).Price;
            ItemType itemType = _itemRepo.GetById(transLine.ItemID).ItemType;
            int qnt = transLine.Quantity;
            decimal discount = 0;

            if (itemType == ItemType.Fuel && (itemPrice * qnt) > 20)
            {
                discount = 0.2m;
            }
            decimal percent = 0;
            if (discount > 0)
            {
                percent = 20;
            }

            TransactionLine newTransLine = new()
            {
                TransactionID = transLine.TransactionID,
                ItemID = transLine.ItemID,
                Quantity = qnt,
                ItemPrice = itemPrice,
                NetValue = qnt * itemPrice,
                DiscountPercent = percent,
                DiscountValue = (qnt * itemPrice) * discount,
                TotalValue = (qnt * itemPrice) - (qnt * itemPrice) * discount,
            };

            _transLineRepo.Add(newTransLine);
        }

        [HttpPut]
        public async Task Put(TransactionLineEditDto transLine)
        {
            decimal itemPrice = _itemRepo.GetById(transLine.ItemID).Price;
            ItemType itemType = _itemRepo.GetById(transLine.ItemID).ItemType;
            int qnt = transLine.Quantity;
            decimal discount = 0;
            if (itemType == ItemType.Fuel && (itemPrice * qnt) > 20)
            {
                discount = 0.2m;
            }
            decimal percent = 0;
            if (discount > 0)
            {
                percent = 20;
            }
            var dbTransLine = _transLineRepo.GetById(transLine.ID);
            if (dbTransLine == null)
            {
                throw new ArgumentNullException();
            }
            dbTransLine.TransactionID = transLine.TransactionID;
            dbTransLine.ItemID = transLine.ItemID;
            dbTransLine.Quantity = qnt;
            dbTransLine.ItemPrice = itemPrice;
            dbTransLine.NetValue = qnt * itemPrice;
            dbTransLine.DiscountPercent = percent;
            dbTransLine.DiscountValue = (qnt * itemPrice) * discount;
            dbTransLine.TotalValue = (qnt * itemPrice) - (qnt * itemPrice) * discount;
            _transLineRepo.Update(transLine.ID, dbTransLine);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _transLineRepo.Delete(id);
        }
    }
}
