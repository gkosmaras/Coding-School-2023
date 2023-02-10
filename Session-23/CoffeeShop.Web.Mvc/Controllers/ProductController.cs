using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Web.Mvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly IEntityRepo<Product> _productRepo;
        private readonly IEntityRepo<ProductCategory> _prodCatRepo;
        public ProductController(IEntityRepo<Product> productRepo, IEntityRepo<ProductCategory> prodCatRepo)
        {
            _productRepo = productRepo;
            _prodCatRepo = prodCatRepo;
        }

        #region Index
        // GET: ProductController
        public ActionResult Index()
        {
            var products = _productRepo.GetAll();
            return View(model: products);
        }
        #endregion
        #region Details
        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = _productRepo.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            var result = new ProductDetailsDto();
            result.Id = product.Id;
            result.Code = product.Code;
            result.Description = product.Description;
            result.Price = product.Price;
            result.Cost = product.Cost;
            result.ProductCategory = _prodCatRepo.GetById(product.ProductCategoryId);
            return View(model: result);
        }
        #endregion 
        #region Create
        // GET: ProductController/Create
        public ActionResult Create()
        {
            var product = new ProductCreateDto();
            var prodCat = _prodCatRepo.GetAll();
            foreach (var cat in prodCat)
            {
                product.ProductCategories.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(cat.Description.ToString(), cat.Id.ToString()));
            }
            return View(model: product);
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductCreateDto product)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbProduct = new Product(product.Code, product.Description, product.Price, product.Cost);
            dbProduct.ProductCategoryId = product.ProductCategoryId;
            _productRepo.Create(dbProduct);
            return RedirectToAction("Index");
        }
        #endregion
        #region Edit
        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            var dbProduct = _productRepo.GetById(id);
            var prodCat = _prodCatRepo.GetAll();
            if (dbProduct == null)
            {
                return NotFound();
            }
            var product = new ProductEditDto();
            product.Id = dbProduct.Id;
            foreach (var cat in prodCat)
            {
                product.ProductCategories.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(cat.Description.ToString(), cat.Id.ToString()));
            }
            product.Code = dbProduct.Code;
            product.Description = dbProduct.Description;
            product.Price = dbProduct.Price;
            product.Cost = dbProduct.Cost;
            product.ProductCategoryId = dbProduct.ProductCategoryId;
            return View(model: product);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProductEditDto product)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbProduct = new Product(product.Code, product.Description, product.Price, product.Cost);
            dbProduct.ProductCategoryId = product.ProductCategoryId;
            _productRepo.Update(product.Id, dbProduct);
            return RedirectToAction("Index");
        }
        #endregion
        #region Delete
        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbProduct = _productRepo.GetById(id);
            if (dbProduct == null)
            {
                return NotFound();
            }
            var product = new ProductDeleteDto();
            product.Id = dbProduct.Id;
            product.Code = dbProduct.Code;
            product.Description = dbProduct.Description;
            product.Price = dbProduct.Price;
            product.Cost = dbProduct.Cost;
            product.ProductCategory = _prodCatRepo.GetById(dbProduct.ProductCategoryId);
            return View(model: product);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _productRepo.Delete(id);
            return RedirectToAction("Index");
        }
        #endregion
    }
}
