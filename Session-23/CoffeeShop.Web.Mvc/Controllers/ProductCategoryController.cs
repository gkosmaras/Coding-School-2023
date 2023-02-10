using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Web.Mvc.Controllers
{
    public class ProductCategoryController : Controller
    {
        private readonly IEntityRepo<ProductCategory> _prodCatRepo;
        public ProductCategoryController(IEntityRepo<ProductCategory> prodCatRepo)
        {
            _prodCatRepo = prodCatRepo;
        }
        #region Index
        // GET: ProductCategoryController
        public ActionResult Index()
        {
            var prodCat = _prodCatRepo.GetAll();
            return View(model: prodCat);
        }
        #endregion
        #region Details
        // GET: ProductCategoryController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var proCat = _prodCatRepo.GetById(id.Value);
            if (_prodCatRepo == null)
            {
                return NotFound();
            }
            var result = new ProductCategoryDetailsDto();
            result.Id = proCat.Id;
            result.Code = proCat.Code;
            result.Description = proCat.Description;
            result.ProductType = proCat.ProductType;
            result.Products = proCat.Products.ToList();
            return View(model: result);
        }
        #endregion
        #region Create
        // GET: ProductCategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductCategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductCategoryCreateDto prodCat)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbProdCat = new ProductCategory(prodCat.Code, prodCat.Description, prodCat.ProductType);
            _prodCatRepo.Create(dbProdCat);
            return RedirectToAction("Index");
        }
        #endregion
        #region Edit
        // GET: ProductCategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var dbProdCat = _prodCatRepo.GetById(id);
            if (dbProdCat == null)
            {
                return NotFound();
            }
            var prodCat = new ProductCategoryEditDto();
            prodCat.Code = dbProdCat.Code;
            prodCat.Description = dbProdCat.Description;
            prodCat.ProductType = dbProdCat.ProductType;
            return View(model: prodCat);
        }

        // POST: ProductCategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProductCategoryEditDto prodCat)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbProdCat = _prodCatRepo.GetById(id);
            if (dbProdCat == null)
            {
                return NotFound();
            }
            dbProdCat.Code = prodCat.Code;
            dbProdCat.Description = prodCat.Description;
            dbProdCat.ProductType = prodCat.ProductType;
            _prodCatRepo.Update(id, dbProdCat);
            return RedirectToAction("Index");
        }
        #endregion
        #region Delete
        // GET: ProductCategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbProdCat = _prodCatRepo.GetById(id);
            if (dbProdCat == null)
            {
                return NotFound();
            }
            var prodCat = new ProductCategoryDeleteDto();
            prodCat.Code = dbProdCat.Code;
            prodCat.Description = dbProdCat.Description;
            prodCat.ProductType = dbProdCat.ProductType;
            return View(model: prodCat);
        }

        // POST: ProductCategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _prodCatRepo.Delete(id);
            return RedirectToAction("Index");
        }
        #endregion
    }
}
