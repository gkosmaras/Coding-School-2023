using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.Blazor.Shared.DTO.Customer;
using PetShop.EF.Repositories;
using PetShop.Models;

namespace PetShop.Blazor.Server.Controllers
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
        public async Task<IEnumerable<CustomerDto>> Get()
        {
            var dbCustomer= _customerRepo.GetAll();
            var result = dbCustomer.Select(cus => new CustomerDto
            {
                Id = cus.Id,
                Name = cus.Name,
                Surname = cus.Surname,
                Phone = cus.Phone,
                Tin = cus.Tin
            });
            return result;
        }

        [HttpGet("{id}")]
        public async Task<CustomerEditDto> GetById(int id)
        {
            var dbCustomer = _customerRepo.GetById(id);
            var result = new CustomerEditDto
            {
                Id = id,
                Name = dbCustomer.Name,
                Surname = dbCustomer.Surname,
                Phone = dbCustomer.Phone,
                Tin = dbCustomer.Tin
            };
            return result;
        }
        public async Task Post(CustomerEditDto customer)
        {
            var dbCustomer = new Customer(customer.Name, customer.Surname, customer.Phone, customer.Tin);
            _customerRepo.Add(dbCustomer);
        }
        [HttpPut]
        public async Task Put(CustomerEditDto customer)
        {
            var dbCustomer = _customerRepo.GetById(customer.Id);
            dbCustomer.Name = customer.Name;
            dbCustomer.Surname = customer.Surname;
            dbCustomer.Phone = customer.Phone;
            dbCustomer.Tin = customer.Tin;
            _customerRepo.Update(customer.Id, dbCustomer);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _customerRepo.Delete(id);
        }
    }
}
