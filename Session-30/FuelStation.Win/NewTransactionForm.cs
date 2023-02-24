using FuelStation.Model.Enums;
using FuelStation.Model.Transactions;
using FuelStation.Web.Blazor.Shared.DTO;
using FuelStation.Web.Blazor.Shared.Validators;
using FuelStation.Win.Handler;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FuelStation.Win
{
    public partial class NewTransactionForm : Form
    {
        private ItemHandler itHandler = new ItemHandler();
        private TransactionLineHandler handler = new TransactionLineHandler();
        private TransactionHandler transHandler = new TransactionHandler();
        private Validator validator = new Validator();
        public NewTransactionForm()
        {
            InitializeComponent();
        }
        private void NewTransactionForm_Load(object sender, EventArgs e)
        {
            
            PopulateGrid();
            SetControlProperties();
        }
        private async Task PopulateGrid()
        {
            int transID = TransactionForm.transID;
            var lines = await handler.PopulateDataGridView();
            bsNewTransaction.DataSource = lines.Where(tLines => tLines.TransactionID == transID);
            grvTransLine.DataSource = null;
            grvTransLine.DataSource = bsNewTransaction;
        }
        private async void SetControlProperties()
        {
            var dbItems = await itHandler.PopulateDataGridView();
            DataGridViewComboBoxColumn colbox = grvTransLine.Columns["clmItemID"] as DataGridViewComboBoxColumn;
            colbox.DataSource = new BindingSource(dbItems, null);
            colbox.DisplayMember = "Description";
            colbox.ValueMember = "ID";

            var dbTransactions = await transHandler.PopulateDataGridView();

            cmbItem.DataSource = new BindingSource(dbItems, null);
            cmbItem.DisplayMember = "Description";
            cmbItem.ValueMember = "ID";

            grvTransLine.AutoGenerateColumns = false;
            nudQuantity.Controls.RemoveAt(0);
            grvTransLine.Columns["clmTransID"].ReadOnly = true;
            grvTransLine.Columns["clmPrice"].ReadOnly = true;
            grvTransLine.Columns["clmValue"].ReadOnly = true;
            grvTransLine.Columns["clmPercent"].ReadOnly = true;
            grvTransLine.Columns["clmDiscount"].ReadOnly = true;
            grvTransLine.Columns["clmTotal"].ReadOnly = true;
            grvTransLine.Columns["clmID"].Visible = false;
            grvTransLine.Columns["clmTransID"].Visible = false;
        }

        private void ReadOnly()
        {
            grvTransLine.Columns["clmQuantity"].ReadOnly = true;
            grvTransLine.Columns["clmItemID"].ReadOnly = true;
        }

        #region Buttons
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (chkEditMode.Checked)
            {
                btnEdit_Click();
            }
            else
            {
                int transID = TransactionForm.transID;
                int itemId = (int)cmbItem.SelectedValue;
                int qnt = (int)nudQuantity.Value;
                if (qnt <= 0)
                {
                    MessageBox.Show("Enter a meaningfull quantity of products", "Error", MessageBoxButtons.OK);
                    return;
                }
                TransactionLineEditDto transLine = new TransactionLineEditDto
                {
                    TransactionID = transID,
                    ItemID = itemId,
                    Quantity = qnt
                };
                Task<bool> task = CheckFuel(itemId);
                bool result = await task;
                if (!result)
                {
                    MessageBox.Show("Only one fuel item allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    await handler.AddTransactionLine(transLine);
                    nudQuantity.Value = 0;
                    await PopulateGrid();
                }
            }
        }

        private async void btnEdit_Click()
        {
            TransactionLineEditDto transLine = (TransactionLineEditDto)bsNewTransaction.Current;
            if (transLine.Quantity <= 0)
            {
                MessageBox.Show("Enter a meaningfull quantity of products", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            await handler.EditTransactionLine(transLine);
            await PopulateGrid();
        }

        private async void btnDone_Click(object sender, EventArgs e)
        {
            int transID = TransactionForm.transID;
            TransactionEditDto dbTransaction = await transHandler.GetTransaction(transID);
            dbTransaction.TransactionLines = new List<TransactionLine>();
            if (radCard.Checked == true)
            {
                dbTransaction.PaymentMethod = PaymentMethod.CreditCard;
            }
            else
            {
                dbTransaction.PaymentMethod = PaymentMethod.Cash;
            }
            bool status = await transHandler.EditTransaction(dbTransaction);
            if (status)
            {
                transID = 0;
                this.Close();
            }
        }
        #endregion
        #region Events
        private void chkEditMode_CheckChanged(object sender, EventArgs e)
        {
            if (chkEditMode.Checked)
            {
                btnAdd.Text = "Save Edit";
                grvTransLine.Columns["clmQuantity"].ReadOnly = false;
                grvTransLine.Columns["clmItemID"].ReadOnly = false;
            }
            else
            {
                btnAdd.Text = "Add New";
                ReadOnly();
            }
        }
        #endregion

        #region Methods
        private async Task<bool> CheckFuel(int id)
        {
            int transID = TransactionForm.transID;
            var result = true;
            var dbItems = await itHandler.PopulateDataGridView();
            var fuels = dbItems
                .Where(it => it.ItemType == ItemType.Fuel)
                .Select(x => x.ID);
            if (fuels.Contains(id))
            {
                var dbTransLines = await handler.PopulateDataGridView();
                var lines = dbTransLines
                    .Where(tLines => tLines.TransactionID == transID)
                    .Select(x => x.ItemID);
                if (lines.Intersect(fuels).Any())
                {
                    result = false;
                }
            }
            return result;
        }
        #endregion
    }
}
