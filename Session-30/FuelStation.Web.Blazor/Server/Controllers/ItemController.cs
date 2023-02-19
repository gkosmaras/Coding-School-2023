using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Blazor.Shared.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Web.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {

        private readonly IEntityRepo<Item> _itemRepo;

        public ItemController(IEntityRepo<Item> itemRepo)
        {
            _itemRepo = itemRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<ItemEditDto>> Get()
        {
            var dbItem = _itemRepo.GetAll();

            var result = dbItem.Select(it => new ItemEditDto
            {
                ID = it.ID,
                Code = it.Code,
                Description = it.Description,
                ItemType = it.ItemType,
                Price = it.Price,
                Cost = it.Cost,
            });
            return result;
        }

        [HttpGet("{id}")]
        public async Task<ItemEditDto> GetById(int id)
        {
            var dbItem = _itemRepo.GetById(id);

            if (dbItem == null)
            {
                throw new ArgumentNullException();
            }

            var result = new ItemEditDto
            {
                ID = id,
                Code = dbItem.Code,
                Description = dbItem.Description,
                ItemType = dbItem.ItemType,
                Price = dbItem.Price,
                Cost = dbItem.Cost,
            };

            return result;
        }

        [HttpPost]
        public async Task Post(ItemEditDto item)
        {
            Item dbItem = new()
            {
                Code = GetCode(item.Code),
                Description = item.Description,
                ItemType = item.ItemType,
                Price = item.Price,
                Cost = item.Cost,
            };
            _itemRepo.Add(dbItem);
        }

        [HttpPut]
        public async Task Put(ItemEditDto item)
        {

            var dbItem = _itemRepo.GetById(item.ID);
            if (dbItem == null)
            {
                throw new ArgumentNullException();
            }
            dbItem.Code = GetCode(item.Code);
            dbItem.Description = item.Description;
            dbItem.ItemType = item.ItemType;
            dbItem.Price = item.Price;
            dbItem.Cost = item.Cost;

            _itemRepo.Update(item.ID, dbItem);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _itemRepo.Delete(id);
        }

        #region Methods
        public int GetCode(int code)
        {
            var dbItem = _itemRepo.GetAll().Select(it => it.Code);
        Check:
            if (CheckCodeUniqueness(code))
            {
                code = dbItem.Max() + 1;
                goto Check;
            }
        return code;
        }

        public bool CheckCodeUniqueness(int code)
        {
            var dbItem = _itemRepo.GetAll().Select(it => it.Code);
            bool result = dbItem.Contains(code);
            return result;
        }
        #endregion
    }
}
