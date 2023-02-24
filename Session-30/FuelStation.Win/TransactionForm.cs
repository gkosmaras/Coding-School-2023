using FuelStation.Model.Enums;
using FuelStation.Model.Transactions;
using FuelStation.Web.Blazor.Shared.DTO;
using FuelStation.Web.Blazor.Shared.Validators;
using FuelStation.Win.Handler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FuelStation.Win
{
    public partial class TransactionForm : Form
    {
        private TransactionHandler handler = new TransactionHandler();
        private CustomerHandler cusHandler = new CustomerHandler();
        private EmployeeHandler eeHandler = new EmployeeHandler();
        private Validator validator = new Validator();
        public static int transID;

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
            grvTransaction.DataSource = null;
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

            grvTransaction.AutoGenerateColumns = false;
            grvTransaction.Columns["clmID"].Visible = false;
            grvTransaction.Columns["clmDate"].ReadOnly = true;
            grvTransaction.Columns["clmTotalValue"].ReadOnly = true;
        }

        private void grvTransaction_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        #region Buttons
        private async void btnNew_Click(object sender, EventArgs e)
        {
            if (chkEditMode.Checked)
            {
                btnEdit_Click();
            }
            else
            {
                int id = validator.ExistingCustomer(txtCardNumber.Text);
                if (id != 0)
                {
                    TransactionEditDto transaction = new TransactionEditDto
                    {
                        CustomerID = id,
                        EmployeeID = (int)cmbEmployee.SelectedValue,
                        TotalValue = 0,
                        TransactionLines = new List<TransactionLine>()
                    };
                    await handler.AddTransaction(transaction);
                    var dbTrasnactions = await handler.PopulateDataGridView();
                    transID = dbTrasnactions.Select(x => x.ID).LastOrDefault();
                    TransactionDetails();
                }
                else
                {
                    CreateCustomerForm createCustomer = new CreateCustomerForm();
                    createCustomer.FormClosing += new FormClosingEventHandler(this.CreateCustomerForm_FormClosing);
                    createCustomer.Show();
                }
            }

        }

        private async void btnEdit_Click()
        {
            TransactionEditDto transLine = (TransactionEditDto)bsTransaction.Current;
            transLine.TransactionLines = new List<TransactionLine>();
            await handler.EditTransaction(transLine);
            await PopulateGrid();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Proceed with transaction deletion?", "Error", MessageBoxButtons.YesNo);
            if (dResult == DialogResult.Yes)
            {
                int id = (int)grvTransaction.CurrentRow.Cells["clmID"].Value;
                await handler.DeleteTransaction(id);
                await PopulateGrid();
            }
            else
            {
                return;
            }
        }
        #endregion

        private void grvTransaction_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            transID = (int)grvTransaction.CurrentRow.Cells["clmID"].Value;
            TransactionDetails();
        }
        private void TransactionDetails()
        {
            NewTransactionForm newTransaction = new NewTransactionForm();
            newTransaction.FormClosing += new FormClosingEventHandler(this.NewTransactionForm_FormClosing);
            newTransaction.Show();
        }
        private async void NewTransactionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var trans = await handler.GetTransaction(transID);
            if (trans.TotalValue == 0)
            {
                handler.DeleteTransaction(transID);
            }
            txtCardNumber.Text = "";
            transID = 0;
            await PopulateGrid();
            // TODO: after completing transaction with new customer refresh correctly
        }
        private async void CreateCustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dbCustomers = await cusHandler.PopulateDataGridView();
            string cusCard = dbCustomers.Last().CardNumber;
            txtCardNumber.Text = cusCard;
            btnSave.PerformClick();
        }

        private void chkEditMode_CheckChanged(object sender, EventArgs e)
        {
            if (chkEditMode.Checked)
            {
                btnSave.Text = "Save Edit";
                grvTransaction.Columns["clmEmployeeID"].ReadOnly = false;
                grvTransaction.Columns["clmCustomerID"].ReadOnly = false;
                grvTransaction.Columns["clmPaymentMethod"].ReadOnly = false;
            }
            else
            {
                btnSave.Text = "Create New";
                grvTransaction.Columns["clmEmployeeID"].ReadOnly = true;
                grvTransaction.Columns["clmCustomerID"].ReadOnly = true;
                grvTransaction.Columns["clmPaymentMethod"].ReadOnly = true;
            }
        }
    }
}
