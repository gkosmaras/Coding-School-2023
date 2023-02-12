using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;
using Transaction = CoffeeShop.Model.Transaction;

namespace CoffeeShop.Web.Mvc.Controllers
{
    public class TransactionController : Controller
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        public TransactionController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Employee> employeeRepo, IEntityRepo<Customer> customerRepo)
        {
            _transactionRepo = transactionRepo;
            _employeeRepo = employeeRepo;
            _customerRepo = customerRepo;
        }

        #region Index
        // GET: HomeController1
        public ActionResult Index()
        {
            var transactions = _transactionRepo.GetAll();
            foreach (var trans in transactions)
            {
                trans.TotalPrice = 0;
                foreach (var transLine in trans.TransactionLines)
                {
                    trans.TotalPrice += transLine.TotalPrice;
                }
            }
            return View(model: transactions);
        }
        #endregion
        #region Details
        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var transaction = _transactionRepo.GetById(id);
            if (transaction == null)
            {
                return NotFound();
            }
            var result = new TransactionDetailsDto();
            result.Id = transaction.Id;
            result.Date = transaction.Date;
            //result.TotalPrice = transaction.TotalPrice;
            result.PaymentMethod = transaction.PaymentMethod;
            result.Employees = _employeeRepo.GetById(transaction.EmployeeId);
            result.Customers = _customerRepo.GetById(transaction.CustomerId);
            result.TransactionLines = transaction.TransactionLines.ToList();
            foreach (var item in result.TransactionLines)
            {
                result.TotalPrice += item.TotalPrice;
            }
            return View(model: result);
        }
        #endregion
        #region Create
        // GET: HomeController1/Create
        public ActionResult Create()
        {
            var transaction = new TransactionCreateDto();
            var customer = _customerRepo.GetAll();
            var employee = _employeeRepo.GetAll();
            foreach (var cus in customer)
            {
                transaction.Customers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(cus.Description.ToString(), cus.Id.ToString()));
            }
            foreach (var ee in employee)
            {
                transaction.Employees.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(ee.Name.ToString(), ee.Id.ToString()));
            }
            return View(model: transaction);
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionCreateDto transaction)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var customer = _customerRepo.GetAll();
            var dbTransaction = new Transaction(transaction.TotalPrice, transaction.PaymentMethod);
            dbTransaction.CustomerId = transaction.CustomerId;
            dbTransaction.EmployeeId = transaction.EmployeeId;
            _transactionRepo.Create(dbTransaction);
            return RedirectToAction("Index");
        }
        #endregion
        //TODO
        #region Edit
        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        #endregion
        #region Delete
        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            var dbTransaction = _transactionRepo.GetById(id);
            if (dbTransaction == null)
            {
                return NotFound();
            }
            var trans = new TransactionDeleteDto();
            trans.Date = dbTransaction.Date;
            trans.TotalPrice = dbTransaction.TotalPrice;
            trans.PaymentMethod = dbTransaction.PaymentMethod;
            trans.CustomerId = dbTransaction.CustomerId;
            trans.EmployeeId = dbTransaction.EmployeeId;
            return View(model: trans);
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _transactionRepo.Delete(id);
            return RedirectToAction("Index");
        }
        #endregion
    }
}
