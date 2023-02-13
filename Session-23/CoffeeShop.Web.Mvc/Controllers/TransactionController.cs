using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;
using System.Diagnostics;
using System.Transactions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
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
                trans.TotalPrice = trans.TransactionLines.Sum(x => x.TotalPrice);
                if (trans.TotalPrice > 10)
                {
                    trans.TotalPrice *= Convert.ToDecimal(0.85);
                }
                _transactionRepo.Update(trans.Id, trans);
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
            result.TotalPrice = transaction.TransactionLines.Sum(x => x.TotalPrice);
            if (result.TotalPrice > 10)
            {
                result.TotalPrice *= Convert.ToDecimal(0.85);
                foreach (var trans in transaction.TransactionLines)
                {
                    trans.Discount = trans.TotalPrice * Convert.ToDecimal(0.15);
                }
            }
            result.PaymentMethod = transaction.PaymentMethod;
            result.Employees = _employeeRepo.GetById(transaction.EmployeeId);
            result.Customers = _customerRepo.GetById(transaction.CustomerId);
            result.TransactionLines = transaction.TransactionLines.ToList();
            ViewBag.Discount = transaction.TransactionLines.Sum(x => x.Discount);
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
            //transaction.Date = DateTime.Now;
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
        #region Edit
        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            var dbTransaction = _transactionRepo.GetById(id);
            var dbEmployees = _employeeRepo.GetAll();
            var dbCustomers = _customerRepo.GetAll();
            if (dbTransaction == null)
            {
                return NotFound();
            }
            var transaction = new TransactionEditDto();
            foreach (var ee in dbEmployees)
            {
                transaction.Employees.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(ee.Name.ToString(), ee.Id.ToString()));
            }
            foreach (var cus in dbCustomers)
            {
                transaction.Customers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(cus.Id.ToString(), cus.Id.ToString()));
            }
            transaction.TotalPrice = dbTransaction.TransactionLines.Sum(x => x.TotalPrice);
            transaction.Date = dbTransaction.Date;
            transaction.PaymentMethod = dbTransaction.PaymentMethod;
            return View(model: transaction);
        }
        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TransactionEditDto transaction)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbTransaction = new Transaction(transaction.TotalPrice, transaction.PaymentMethod);
            dbTransaction.CustomerId = transaction.CustomerId;
            dbTransaction.EmployeeId = transaction.EmployeeId;
            dbTransaction.PaymentMethod = transaction.PaymentMethod;
            _transactionRepo.Update(transaction.Id, dbTransaction);
            return RedirectToAction("Index");
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
            trans.Employee = _employeeRepo.GetById(dbTransaction.EmployeeId);
            trans.Customer = _customerRepo.GetById(dbTransaction.CustomerId);
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
        #region Editor
        public ActionResult Editor(int id)
        {
            var dbTransaction = _transactionRepo.GetById(id);
            var dbEmployees = _employeeRepo.GetAll();
            var dbCustomers = _customerRepo.GetAll();
            if (dbTransaction == null)
            {
                return NotFound();
            }
            var transaction = new TransactionEditDto();
            foreach (var ee in dbEmployees)
            {
                transaction.Employees.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(ee.Name.ToString(), ee.Id.ToString()));
            }
            foreach (var cus in dbCustomers)
            {
                transaction.Customers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(cus.Id.ToString(), cus.Id.ToString()));
            }
            transaction.TotalPrice = dbTransaction.TransactionLines.Sum(x => x.TotalPrice);
            transaction.Date = dbTransaction.Date;
            transaction.PaymentMethod = dbTransaction.PaymentMethod;
            return View(model: transaction);
        }
        // POST: HomeController1/Editor/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editor(int id, TransactionEditDto transaction)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbTransaction = new Transaction(transaction.TotalPrice, transaction.PaymentMethod);
            dbTransaction.CustomerId = transaction.CustomerId;
            dbTransaction.EmployeeId = transaction.EmployeeId;
            dbTransaction.PaymentMethod = transaction.PaymentMethod;
            _transactionRepo.Update(transaction.Id, dbTransaction);
            return RedirectToAction("Index");
        }
        #endregion
    }
}
