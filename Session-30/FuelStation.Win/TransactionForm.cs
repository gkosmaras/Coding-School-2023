using FuelStation.Model.Enums;
using FuelStation.Win.Handler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Win
{
    public partial class TransactionForm : Form
    {
        private TransactionHandler handler = new TransactionHandler();
        private CustomerHandler cusHandler = new CustomerHandler();
        private EmployeeHandler eeHandler = new EmployeeHandler();
        public TransactionForm()
        {
            InitializeComponent();
        }
        private void TransactionForm_load(object sender, EventArgs e)
        {
            SetControlProperties();
            PopulateGrid();
        }

        private async Task PopulateGrid()
        {
            bsTransaction.DataSource = await handler.PopulateDataGridView();
            grvTransaction.DataSource = bsTransaction;
        }
        private async void SetControlProperties()
        {
            DataGridViewComboBoxColumn colboxPay = grvTransaction.Columns["clmPaymentMethod"] as DataGridViewComboBoxColumn;
            foreach (var value in Enum.GetValues(typeof(PaymentMethod)))
            {
                colboxPay.Items.Add(value);
            }

            var dbCustomers = await cusHandler.PopulateDataGridView();
            DataGridViewComboBoxColumn colboxCustomer = grvTransaction.Columns["clmCustomerID"] as DataGridViewComboBoxColumn;
            colboxCustomer.DataSource = new BindingSource(dbCustomers, null);
            colboxCustomer.DisplayMember = "Name";
            colboxCustomer.ValueMember = "ID";
            

/*            var dbEmployees = await eeHandler.PopulateDataGridView();
            DataGridViewComboBoxColumn colboxEmployee = grvTransaction.Columns["clmEmployeeID"] as DataGridViewComboBoxColumn;
            colboxEmployee.DataSource = new BindingSource(dbEmployees, null);
            colboxEmployee.DisplayMember = "Name";
            colboxEmployee.ValueMember = "ID";*/


            grvTransaction.Columns["clmID"].Visible = false;
        }

/*        private void grvTransaction_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }*/
    }
}
