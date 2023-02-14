using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.Blazor.Shared.DTO;
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
    }
}
