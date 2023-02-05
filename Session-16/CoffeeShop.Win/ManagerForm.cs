using DevExpress.DataAccess.Native.Data;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Cms;
using DevExpress.Utils.DPI;
using DevExpress.XtraCharts;
using DevExpress.XtraSpreadsheet.Export;
using DevExpress.XtraSpreadsheet.Model;
using CoffeeShop.Model;
using System.Collections.ObjectModel;
using System.Linq;
using CoffeeShop.Orm.Repositories;
using static DevExpress.Utils.Svg.CommonSvgImages;
using static CoffeeShop.Model.Product;
using Microsoft.EntityFrameworkCore;

namespace Session_11
{
    public partial class ManagerForm : Form {
       
        public CoffeeShopData Data { get; set; }
        private CoffeeShopData _CoffeeShopData=new CoffeeShopData();
/*        List<Product> products;
        List<Employee> employees;
        List<TransactionLine> transaction_Lines;*/
        Serializer serializer = new Serializer();
        private EmployeeRepository _eeRepo = new EmployeeRepository();

        public ManagerForm(CoffeeShopData test) 
        {
            //_CoffeeShopData = test;
            InitializeComponent();
            refreshEmployees();
            btnSaveEmployees.Enabled = false;
            btnSaveProducts.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            gridProducts.DataSource = _CoffeeShopData.products;
        }
        public void WriteJson(object obj, string file) 
        {
            serializer.SerializeToFile(obj, file);
        }
        public void btnSaveEmployeesClick(object sender, EventArgs e) 
        {
            Employee newEmployee = new Employee() {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                TypeOfEmployee = (EmployeeType)Enum.Parse(typeof(EmployeeType), cmbType.SelectedItem.ToString()),
                SalaryPerMonth = Convert.ToDecimal(txtSalary.Text)
            };
            txtName.Text = "";
            txtSurname.Text = "";
            cmbType.Text = "";
            txtSalary.Text = "";
            _eeRepo.Add(newEmployee);
            refreshEmployees();
        }
        public void btnSaveProductsClick(object sender, EventArgs e)
        {
            Product newProduct = new Product()
            {
                Description = txtDesc.Text,
                Code = GetCode(),
                TypeOfProduct = (ProductType)Enum.Parse(typeof(ProductType), cmbProType.SelectedItem.ToString()),
                Price = Convert.ToDecimal(txtPrice.Text),
                Cost = Convert.ToDecimal(txtCost.Text)
            };
            txtDesc.Text = "";
            cmbProType.Text = "";
            txtPrice.Text = "";
            txtCost.Text = "";
            gridProducts.DataSource = null;
            gridProducts.DataSource = _CoffeeShopData.products;
        }
        public void refreshEmployees()
        {
            gridEmployee.DataSource = null;
            gridEmployee.DataSource = _eeRepo.GetAll();
            gridEmployee.Update();
            gridEmployee.Refresh();
        }
        public void btnLoadEmployees_Click(object sender, EventArgs e)
        {
            refreshEmployees();
        }
        public void btnSaveJson(object sender, EventArgs e)
        {
            List<Employee> employees = _eeRepo.GetAll();
            foreach(var ee in employees)
            {
                _eeRepo.Delete(ee.ID);
            }
            employees = gridEmployee.DataSource as List<Employee>;
            foreach (var ee in employees)
            {
                _eeRepo.Add(ee);
            }
            //WriteJson(_CoffeeShopData, "test1.json") ;
        }
        private bool setEmployeeButtonVisibility()
        {
            bool res = false;
            if ((txtName.Text != String.Empty)
                && (txtSurname.Text != String.Empty)
                && (txtSalary.Text != String.Empty)
                && (cmbType.SelectedItem != null))
            {
                res = true;
            }
            return res;
        }
        private bool setProductsButtonVisibility()
        {
            bool res = false;
            if ((txtDesc.Text != String.Empty)
                && (txtCost.Text != String.Empty)
                && (txtPrice.Text != String.Empty)
                && (cmbProType.SelectedItem != null))
            {
                res = true;
            }
            return res;
        }
        private void Employee_TextChanged(object sender, EventArgs e)
        {
            bool visibility;
            visibility = setEmployeeButtonVisibility();
            btnSaveEmployees.Enabled = visibility;
        }
        private void Products_TextChanged(object sender, EventArgs e)
        {
            bool visibility;
            visibility = setProductsButtonVisibility();
            btnSaveProducts.Enabled = visibility;
        }
        public void LedgerEntry()
        {
            int rent = 3000;
            List<MonthlyLedger> monthlyLedgers= new List<MonthlyLedger>();
            List<Transaction> transactions = _CoffeeShopData.transactions;
            List<Employee> employees = _CoffeeShopData.employees;
            decimal income = transactions.Sum(x => x.TotalPrice);
            decimal expensesProd = transactions.Sum(x => x.Cost);
            decimal expensesSal = employees.Sum(x => x.SalaryPerMonth);
            decimal total = (income - expensesProd - expensesSal - rent);
            MonthlyLedger ledger = new MonthlyLedger()
            {
                Income = income,
                Expenses = expensesProd + expensesSal + rent,
                Total = total
            };
            monthlyLedgers.Add(ledger);
            gridLedger.DataSource = null;
            gridLedger.DataSource = monthlyLedgers;
        }
        public int GetCode()
        {
            int code = -1;
            List<Product> existingProducts = _CoffeeShopData.products;
            Int32 length = existingProducts.Count;
            if (length == 0)
            {
                code = 0;
            }
            else
            {
                foreach (var i in existingProducts)
                {
                    if (code < i.Code)
                    {
                        code = i.Code;
                    }
                }
            }
            code++;
            return code;
        }
        private void btnLedger_Click(object sender, EventArgs e)
        {
            LedgerEntry();
        }
        public void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EntryPoint entryPoint = new EntryPoint();
            entryPoint.Show();
        }
    } 
}