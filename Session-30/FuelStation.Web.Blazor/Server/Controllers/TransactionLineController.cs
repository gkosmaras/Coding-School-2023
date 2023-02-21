using FuelStation.EF.Repositories;
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

        public TransactionLineController(IEntityRepo<TransactionLine> transLineRepo)
        {
            _transLineRepo = transLineRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionLineEditDto>> Get()
        {
            var dbTransLine = _transLineRepo.GetAll();

            var result = dbTransLine.Select(tLine => new TransactionLineEditDto
            {
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
                TotalValue = dbTransLine.TotalValue,
            };
            return result;
        }

        [HttpPost]
        public async Task Post(TransactionLineEditDto transLine)
        {
            TransactionLine newTransLine = new()
            {
                TransactionID = transLine.TransactionID,
                ItemID = transLine.ItemID,
                Quantity = transLine.Quantity,
                ItemPrice = transLine.ItemPrice,
                NetValue = transLine.NetValue,
                DiscountPercent = transLine.DiscountPercent,
                DiscountValue = transLine.DiscountValue,
                TotalValue = transLine.TotalValue,
            };

            await Task.Run(() => { _transLineRepo.Add(newTransLine); });
        }

        [HttpPut]
        public async Task Put(TransactionLineEditDto transLine)
        {
            var dbTransLine = _transLineRepo.GetById(transLine.ID);
            if (dbTransLine == null)
            {
                throw new ArgumentNullException();
            }

            _transLineRepo.Update(transLine.ID, dbTransLine);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _transLineRepo.Delete(id);
        }
    }
}
