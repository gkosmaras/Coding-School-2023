using FuelStation.Web.Blazor.Shared.DTO;
using FuelStation.Win.Handler;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Win
{
    public partial class DetailsForm : Form
    {
        private TransactionHandler handler = new TransactionHandler();
        private TransactionLineHandler lineHandler = new TransactionLineHandler();
        private ItemHandler itHandler = new ItemHandler();
        private object result;

        public DetailsForm()
        {
            InitializeComponent();
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            PopulateGrid();
            SetControlProperties();
        }
        private async Task PopulateGrid()
        {
            int cusID = CustomerForm.cusID;
            int itID = ItemForm.itID;
            var transaction = await handler.PopulateDataGridView();
            var lines = await lineHandler.PopulateDataGridView();
            if (cusID != 0)
            {
                var temp = transaction.Where(x => x.CustomerID == cusID).Select(x => x.ID);
                result = lines.Where(x => temp.Contains(x.TransactionID));
            }
            else
            {
                result = lines.Where(x => x.ItemID == itID);
            }
            bsTransLine.DataSource = result;
            grvTransLine.DataSource = null;
            grvTransLine.DataSource = bsTransLine;
        }

        private async void SetControlProperties()
        {
            var dbItems = await itHandler.PopulateDataGridView();
            DataGridViewComboBoxColumn colbox = grvTransLine.Columns["clmItemID"] as DataGridViewComboBoxColumn;
            colbox.DataSource = new BindingSource(dbItems, null);
            colbox.DisplayMember = "Description";
            colbox.ValueMember = "ID";

            grvTransLine.AutoGenerateColumns = false;
            grvTransLine.Columns["clmQuantity"].ReadOnly = true;
            grvTransLine.Columns["clmItemID"].ReadOnly = true;
            grvTransLine.Columns["clmTransID"].ReadOnly = true;
            grvTransLine.Columns["clmPrice"].ReadOnly = true;
            grvTransLine.Columns["clmValue"].ReadOnly = true;
            grvTransLine.Columns["clmPercent"].ReadOnly = true;
            grvTransLine.Columns["clmDiscount"].ReadOnly = true;
            grvTransLine.Columns["clmTotal"].ReadOnly = true;
            grvTransLine.Columns["clmID"].Visible = false;
            grvTransLine.Columns["clmTransID"].Visible = false;
        }
    }
}
