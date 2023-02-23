using FuelStation.Model.Enums;
using FuelStation.Model.Transactions;
using FuelStation.Web.Blazor.Shared.DTO;
using FuelStation.Web.Blazor.Shared.Validators;
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
        private Validator validator = new Validator();
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

            var dbEmployees = await eeHandler.PopulateDataGridView();
            cmbEmployee.DataSource = new BindingSource(dbEmployees, null);
            cmbEmployee.DisplayMember = "Name";
            cmbEmployee.ValueMember = "ID";

            // HACK: not sure if that DataError solution is stable
            DataGridViewComboBoxColumn colboxEmployee = grvTransaction.Columns["clmEmployeeID"] as DataGridViewComboBoxColumn;
            colboxEmployee.DataSource = new BindingSource(dbEmployees, null);
            colboxEmployee.DisplayMember = "Name";
            colboxEmployee.ValueMember = "ID";

            grvTransaction.Columns["clmID"].Visible = false;
        }

        private void grvTransaction_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        private async void btnNew_Click(object sender, EventArgs e)
        {
            
            int id = validator.ExistingCustomer(txtCardNumber.Text);
            if (id != 0)
            {
                TransactionEditDto transaction = new TransactionEditDto
                {
                    CustomerID = id,
                    EmployeeID = (int)cmbEmployee.SelectedValue,
                    PaymentMethod = PaymentMethod.Cash,
                    TotalValue = 0,
                    TransactionLines = new List<TransactionLine>()
                };
                await handler.AddTransaction(transaction);
                NewTransactionForm newTransaction = new NewTransactionForm();
                newTransaction.FormClosing += new FormClosingEventHandler(this.NewTransactionForm_FormClosing);
                newTransaction.Show();
            }
            else
            {
                // TODO: create new customer
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Proceed with transaction deletion?", "Error", MessageBoxButtons.YesNo);
            if (dResult == DialogResult.Yes)
            {
                int id = (int)grvTransaction.CurrentRow.Cells["clmID"].Value;
                await handler.DeleteTransaction(id);
                bsTransaction.RemoveCurrent();
            }
            else
            {
                return;
            }
        }

        private async void NewTransactionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            await PopulateGrid();
        }
    }
}
