using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Blazor.Shared.DTO;
using FuelStation.Web.Blazor.Shared.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace FuelStation.Web.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {

        private readonly IEntityRepo<Item> _itemRepo;
        private readonly IValidator _validator;
        public string errorMessage = string.Empty;

        public ItemController(IEntityRepo<Item> itemRepo, IValidator validator)
        {
            _itemRepo = itemRepo;
            _validator = validator;
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
        public async Task<ActionResult> Post(ItemEditDto item)
        {
            Item newItem = new()
            {
                Code = item.Code,
                Description = item.Description,
                ItemType = item.ItemType,
                Price = item.Price,
                Cost = item.Cost,
            };

            var dbItem = _itemRepo.GetAll().ToList();
            if (_validator.ValidateAddItem(newItem.Code, out errorMessage))
            {
                try
                {
                    await Task.Run(() => { _itemRepo.Add(newItem); });
                }
                catch (DbException ex)
                {
                    return BadRequest(ex.Message);
                }
                return Ok();
            }
            return BadRequest(errorMessage);
        }

        [HttpPut]
        public async Task<ActionResult> Put(ItemEditDto item)
        {

            var dbItem = _itemRepo.GetById(item.ID);
            if (dbItem == null)
            {
                throw new ArgumentNullException();
            }

            if (_validator.ValidateUpdateItem(item.Code, dbItem, out errorMessage))
            {
                dbItem.Code = item.Code;
                dbItem.Description = item.Description;
                dbItem.ItemType = item.ItemType;
                dbItem.Price = item.Price;
                dbItem.Cost = item.Cost;
                try
                {
                    _itemRepo.Update(item.ID, dbItem);
                }
                catch (DbUpdateException ex)
                {
                    return BadRequest(ex.Message);
                }
                return Ok();
            }
            else
            {
                return BadRequest(errorMessage);
            }
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _itemRepo.Delete(id);
        }

    }
}
