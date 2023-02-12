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
            if (CheckEmployeesCreate(employee)) 
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
            if (CheckEmployeesEdit(employee))
            {
                _employeeRepo.Update(id, dbEmployee);
            }
            else
            {
                ViewBag.Message = string.Format("Employee limit has been reached for the position of {0}.", employee.EmployeeType);
                return View();
            }
            return RedirectToAction("Index");
        }
        #endregion
        #region Delete
        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbEmployee = _employeeRepo.GetById(id);
            var employee = new EmployeeDeleteDto();
            if (dbEmployee == null)
            {
                return NotFound();
            }
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
            var dbEmployee = _employeeRepo.GetById(id);
            var employee = new EmployeeDeleteDto();
            if (CheckEmployeesDelete(id))
            {
                _employeeRepo.Delete(id);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = string.Format("Can not delete the last worker from position {0}.", dbEmployee.EmployeeType);
                employee.Name = dbEmployee.Name;
                employee.Surname = dbEmployee.Surname;
                employee.SalaryPerMonth = dbEmployee.SalaryPerMonth;
                employee.EmployeeType = dbEmployee.EmployeeType;
                return View(model: employee);
            }
            
        }
        #endregion
        #region Methods
        public bool CheckEmployeesCreate(EmployeeCreateDto employee)
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
        public bool CheckEmployeesEdit(EmployeeEditDto employee)
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
        public bool CheckEmployeesDelete(int id)
        {
            bool result = true;
            var dbEmployees = _employeeRepo.GetAll();
            var employee = _employeeRepo.GetById(id);
            int manager = dbEmployees.Where(ee => ee.EmployeeType == EmployeeType.Manager).Count();
            int barista = dbEmployees.Where(ee => ee.EmployeeType == EmployeeType.Barista).Count();
            int waiter = dbEmployees.Where(ee => ee.EmployeeType == EmployeeType.Waiter).Count();
            int cashier = dbEmployees.Where(ee => ee.EmployeeType == EmployeeType.Cashier).Count();
            if (employee.EmployeeType == EmployeeType.Manager)
            {
                result = false;
            }
            if (employee.EmployeeType == EmployeeType.Barista & barista == 1)
            {
                return false;
            }
            if (employee.EmployeeType == EmployeeType.Waiter & waiter == 1)
            {
                return false;
            }
            if (employee.EmployeeType == EmployeeType.Cashier & cashier == 1)
            {
                return false;
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
            if (manager > 1 || manager < 1)
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
                var temp = new Employee("Name1", "Surname1", 1, EmployeeType.Manager);
                _employeeRepo.Create(temp);
                temp = new Employee("Name2", "Surname2", 2, EmployeeType.Barista);
                _employeeRepo.Create(temp);
                temp = new Employee("Name3", "Surname3", 3, EmployeeType.Cashier);
                _employeeRepo.Create(temp);
                temp = new Employee("Name4", "Surname4", 4, EmployeeType.Waiter);
                _employeeRepo.Create(temp);
            }
        }
        #endregion
    }
}
