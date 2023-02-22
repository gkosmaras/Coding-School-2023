using FuelStation.Model.Enums;
using FuelStation.Web.Blazor.Shared.DTO;
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
        private static int transID;
        public NewTransactionForm()
        {
            InitializeComponent();
        }
        private void NewTransactionForm_Load(object sender, EventArgs e)
        {
            SetControlProperties();
            PopulateGrid();
        }
        private async Task PopulateGrid()
        {
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
            transID = dbTransactions.Last().ID;

            cmbItem.DataSource = new BindingSource(dbItems, null);
            cmbItem.DisplayMember = "Description";
            cmbItem.ValueMember = "ID";

            nudQuantity.Controls.RemoveAt(0);
            grvTransLine.Columns["clmTransID"].ReadOnly = true;
            grvTransLine.Columns["clmPrice"].ReadOnly = true;
            grvTransLine.Columns["clmValue"].ReadOnly = true;
            grvTransLine.Columns["clmPercent"].ReadOnly = true;
            grvTransLine.Columns["clmDiscount"].ReadOnly = true;
            grvTransLine.Columns["clmTotal"].ReadOnly = true;
            grvTransLine.Columns["clmID"].Visible = false;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
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
            await handler.AddTransactionLine(transLine);
            nudQuantity.Value = 0;
            PopulateGrid();
        }

        private async void btnDone_Click(object sender, EventArgs e)
        {
            var lines = await handler.PopulateDataGridView();
            decimal sum = lines.Where(x => x.TransactionID == transID).Sum(x => x.TotalValue);
            if (radCard.Checked == true && sum > 50)
            {
                MessageBox.Show("Payments over 50€ must be made with cash", "Warning", MessageBoxButtons.OK);
                return;
            }
            else if (radCard.Checked == true)
            {
                var dbTransactions = await transHandler.PopulateDataGridView();
                var temp = dbTransactions.Last();
                temp.PaymentMethod = PaymentMethod.CreditCard;
                await transHandler.EditTransaction(temp);
            }
            this.Close();
        }
    }
}
