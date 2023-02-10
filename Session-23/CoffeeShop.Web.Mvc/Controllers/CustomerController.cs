using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Web.Mvc.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        public CustomerController(IEntityRepo<Customer> customerRepo)
        {
            _customerRepo= customerRepo;
        }
        #region Index
        // GET: CustomerController
        public ActionResult Index()
        {
            var customers = _customerRepo.GetAll();
            return View(model: customers);
        }
        #endregion
        #region Details
        // GET: CustomerController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var customer = _customerRepo.GetById(id.Value);
            if (customer is null)
            {
                return NotFound();
            }
            var result = new CustomerDetailsDto();
            result.Id = customer.Id;
            result.Code = customer.Code;
            result.Description = customer.Description;
            result.Transactions = customer.Transactions.ToList();
            return View(model: result);
        }
        #endregion
        #region Create
        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerCreateDto customer)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbCustomer = new Customer(customer.Code, customer.Description);
            _customerRepo.Create(dbCustomer);
            return RedirectToAction("Index");
        }
        #endregion
        #region Edit
        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            var dbCustomer = _customerRepo.GetById(id);
            if (dbCustomer == null)
            {
                return NotFound();
            }
            var customer = new CustomerEditDto();
            customer.Code = dbCustomer.Code;
            customer.Description = dbCustomer.Description;
            return View(model: customer);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CustomerEditDto customer)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbCustomer = _customerRepo.GetById(id);
            if (dbCustomer == null)
            {
                return NotFound();
            }
            dbCustomer.Code = customer.Code;
            dbCustomer.Description = customer.Description;
            _customerRepo.Update(id, dbCustomer);
            return RedirectToAction("Index");
        }
        #endregion
        #region Delete
        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbCustomer = _customerRepo.GetById(id);
            if (dbCustomer == null)
            {
                return NotFound();
            }
            var customer = new CustomerDeleteDto();
            customer.Code = dbCustomer.Code;
            customer.Description = dbCustomer.Description;
            return View(model: customer);
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _customerRepo.Delete(id);
            return RedirectToAction("Index");
        }
        #endregion
    }
}
