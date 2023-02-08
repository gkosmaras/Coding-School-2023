using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using CoffeeShop.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoffeeShop.Web.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEntityRepo<Customer> _customerRepo;

        public HomeController(ILogger<HomeController> logger, IEntityRepo<Customer> customerRepo)
        {
            _logger = logger;
            _customerRepo = customerRepo;
        }

        public IActionResult Index()
        {
            _customerRepo.GetAll();
            string name = "Giorgos";
            return View(model: name);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}