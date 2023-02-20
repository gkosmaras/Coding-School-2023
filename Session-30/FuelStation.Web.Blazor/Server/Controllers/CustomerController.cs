using FuelStation.EF.Repositories;
using FuelStation.Model.People;
using FuelStation.Model.Transactions;
using FuelStation.Web.Blazor.Shared;
using FuelStation.Web.Blazor.Shared.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.CodeDom.Compiler;

namespace FuelStation.Web.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly IEntityRepo<Customer> _customerRepo;

        public CustomerController(IEntityRepo<Customer> customerRepo)
        {
            _customerRepo = customerRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerEditDto>> Get()
        {

            var dbCustomer = _customerRepo.GetAll();

            var result = dbCustomer.Select(cus => new CustomerEditDto
            {
                ID = cus.ID,
                Name = cus.Name,
                Surname = cus.Surname,
                CardNumber = cus.CardNumber
            });

            return result;

        }

        [HttpGet("{id}")]
        public async Task<CustomerEditDto> GetById(int id)
        {

            var dbCustomer = _customerRepo.GetById(id);

            if (dbCustomer == null)
            {
                throw new ArgumentNullException();
            }

            var result = new CustomerEditDto
            {
                ID = id,
                Name = dbCustomer.Name,
                Surname = dbCustomer.Surname,
                CardNumber = dbCustomer.CardNumber
            };

            return result;

        }

        [HttpPost]
        public async Task Post(CustomerEditDto customer)
        {
            CardGenerator card = new CardGenerator();
            Customer dbCustomer = new()
            {
                Name = customer.Name,
                Surname = customer.Surname,
                CardNumber = card.GetCardNumber(),
            };
            _customerRepo.Add(dbCustomer);
        }

        [HttpPut]
        public async Task Put(CustomerEditDto customer)
        {

            var dbCustomer = _customerRepo.GetById(customer.ID);

            if (dbCustomer == null)
            {
                throw new ArgumentNullException();
            }

            dbCustomer.Name = customer.Name;
            dbCustomer.Surname = customer.Surname;

            _customerRepo.Update(customer.ID, dbCustomer);

        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _customerRepo.Delete(id);
        }



    }

}

