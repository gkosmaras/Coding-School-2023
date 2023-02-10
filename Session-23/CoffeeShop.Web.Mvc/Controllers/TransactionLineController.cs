using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks.Dataflow;

namespace CoffeeShop.Web.Mvc.Controllers
{
    public class TransactionLineController : Controller
    {
        private readonly IEntityRepo<TransactionLine> _transLineRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Product> _productRepo;
        public TransactionLineController(IEntityRepo<TransactionLine> transLineRepo, IEntityRepo<Transaction> TransactionRepo, IEntityRepo<Product> productRepo)
        {
            _transLineRepo = transLineRepo;
            _transactionRepo = TransactionRepo;
            _productRepo = productRepo;
        }
        #region Index
        // GET: TransactionLineController
        public ActionResult Index()
        {
            var transLines = _transLineRepo.GetAll();
            return View(model: transLines);
        }
        #endregion
        #region Details
        // GET: TransactionLineController/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var transLine = _transLineRepo.GetById(id);
            if (transLine == null)
            {
                return NotFound();
            }
            var result = new TransactionLineDetailsDto();
            result.Id = transLine.Id;
            result.Quantity = transLine.Quantity;
            result.Discount = transLine.Discount;
            result.Price = transLine.Price;
            result.TotalPrice = transLine.TotalPrice;
            return View(model: result);
        }
        #endregion
        #region Create
        // GET: TransactionLineController/Create
        public ActionResult Create()
        {
            var transLine = new TransactionLineCreateDto();
            var products = _productRepo.GetAll();
            foreach (var prod in products)
            {
                transLine.Products.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(prod.Description.ToString(), prod.Id.ToString()));
            }
            return View(model: transLine);
        }

        // POST: TransactionLineController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionLineCreateDto transLine)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var products = _productRepo.GetAll();
            var price = products.Where(prod => prod.Id == transLine.ProductId).SingleOrDefault();
            var dbTransLine = new TransactionLine(transLine.Quantity, transLine.Discount, price.Price, transLine.Quantity*price.Price);
            dbTransLine.ProductId = transLine.ProductId;
            _transLineRepo.Create(dbTransLine);
            return RedirectToAction("Index");
        }
        #endregion
        #region Edit
        // GET: TransactionLineController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TransactionLineController/Edit/5
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
        // GET: TransactionLineController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TransactionLineController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
