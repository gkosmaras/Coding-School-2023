using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using CoffeeShop.Model.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CoffeeShop.Web.Mvc.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEntityRepo<Employee> _employeeRepo;
        public EmployeeController(IEntityRepo<Employee> employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }
        #region Index
        // GET: EmployeeController
        public ActionResult Index()
        {
            CheckInitialEmployees();
            var employees = _employeeRepo.GetAll();
            return View(model: employees);
        }
        #endregion
        #region Details
        // GET: EmployeeController/Details/5
        public ActionResult Details(int? id)
        {
            if (id is null)
            {
                return NotFound();
            }
            var employee = _employeeRepo.GetById(id.Value);
            if (employee is null)
            {
                return NotFound();
            }
            var result = new EmployeeDetailsDto();
            result.Id = employee.Id;
            result.Name = employee.Name;
            result.Surname = employee.Surname;
            result.SalaryPerMonth = employee.SalaryPerMonth;
            result.EmployeeType = employee.EmployeeType;
            result.Transactions = employee.Transactions.ToList();
            return View(model: result);
        }
        #endregion
        #region Create
        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeCreateDto employee)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            bool result = CheckEmployees(employee);
            if (result) 
            {
                var dbEmployee = new Employee(employee.Name, employee.Surname, employee.SalaryPerMonth, employee.EmployeeType);
                _employeeRepo.Create(dbEmployee);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = string.Format("Employee limit has been reached for the position of {0}.", employee.EmployeeType);
                return View();
            }

        }
        #endregion
        #region Edit
        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var dbEmployee = _employeeRepo.GetById(id);
            if (dbEmployee == null)
            {
                return NotFound();
            }
            var employee = new EmployeeEditDto();
            employee.Name = dbEmployee.Name;
            employee.Surname = dbEmployee.Surname;
            employee.SalaryPerMonth = dbEmployee.SalaryPerMonth;
            employee.EmployeeType = dbEmployee.EmployeeType;
            return View(model: employee);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EmployeeEditDto employee)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbEmployee = _employeeRepo.GetById(id);
            if (dbEmployee == null)
            {
                return NotFound();
            }
            dbEmployee.Name = employee.Name;
            dbEmployee.Surname = employee.Surname;
            dbEmployee.SalaryPerMonth = employee.SalaryPerMonth;
            dbEmployee.EmployeeType = employee.EmployeeType;
            _employeeRepo.Update(id, dbEmployee);
            return RedirectToAction("Index");
        }
        #endregion
        #region Delete
        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbEmployee = _employeeRepo.GetById(id);
            if (dbEmployee == null)
            {
                return NotFound();
            }
            var employee = new EmployeeDeleteDto();
            employee.Name = dbEmployee.Name;
            employee.Surname = dbEmployee.Surname;
            employee.SalaryPerMonth = dbEmployee.SalaryPerMonth;
            employee.EmployeeType = dbEmployee.EmployeeType;
            return View(model: employee);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _employeeRepo.Delete(id);
            return RedirectToAction("Index");
        }
        #endregion
        public bool CheckEmployees(EmployeeCreateDto employee)
        {
            bool result = true;
            var type = employee.EmployeeType;
            var dbEmployees = _employeeRepo.GetAll();
            int manager = dbEmployees.Where(ee => ee.EmployeeType == EmployeeType.Manager).Count();
            int barista = dbEmployees.Where(ee => ee.EmployeeType == EmployeeType.Barista).Count();
            int waiter = dbEmployees.Where(ee => ee.EmployeeType == EmployeeType.Waiter).Count();
            int cashier = dbEmployees.Where(ee => ee.EmployeeType == EmployeeType.Cashier).Count();
            if (type == EmployeeType.Manager & manager >= 1)
            {
                result = false;
            }
            if (type == EmployeeType.Barista & barista >= 2)
            {
                result = false;
            }
            if (type == EmployeeType.Cashier & cashier >= 2)
            {
                result = false;
            }
            if (type == EmployeeType.Waiter & waiter >= 3)
            {
                result = false;
            }
            return result;
        }
        public void CheckInitialEmployees()
        {
            bool overpopulated = false;
            var dbEmployees = _employeeRepo.GetAll();
            int manager = dbEmployees.Where(ee => ee.EmployeeType == EmployeeType.Manager).Count();
            int barista = dbEmployees.Where(ee => ee.EmployeeType == EmployeeType.Barista).Count();
            int waiter = dbEmployees.Where(ee => ee.EmployeeType == EmployeeType.Waiter).Count();
            int cashier = dbEmployees.Where(ee => ee.EmployeeType == EmployeeType.Cashier).Count();
            if (manager >1 || manager < 1)
            {
                overpopulated = true;
            }
            if (barista > 2 || barista < 1)
            {
                overpopulated = true;
            }
            if (cashier > 2 || cashier < 1)
            {
                overpopulated = true;
            }
            if (waiter > 3 || waiter < 1)
            {
                overpopulated = true;
            }
            Populate(overpopulated);
        }
        public void Populate(bool overpopulated)
        {
            if (overpopulated)
            {
                var dbEmployees = _employeeRepo.GetAll();
                foreach (var ee in dbEmployees)
                {
                    _employeeRepo.Delete(ee.Id);
                }
                var temp= new Employee("Name1", "Surname1", 1, EmployeeType.Manager);
                _employeeRepo.Create(temp);
                temp = new Employee("Name2", "Surname2", 2, EmployeeType.Barista);
                _employeeRepo.Create(temp);
                temp = new Employee("Name3", "Surname3", 3, EmployeeType.Cashier);
                _employeeRepo.Create(temp);
                temp = new Employee("Name4", "Surname4", 4, EmployeeType.Waiter);
                _employeeRepo.Create(temp);
            }
        }
    }
}
