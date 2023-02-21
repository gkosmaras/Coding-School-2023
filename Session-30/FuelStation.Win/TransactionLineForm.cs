using FuelStation.EF.Context;
using FuelStation.Web.Blazor.Shared.DTO;
using FuelStation.Win.Handler;
using Syncfusion.Blazor.Diagrams;
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
using System.Xml.Linq;

namespace FuelStation.Win
{
    public partial class TransactionLineForm : Form
    {
        private ItemHandler itHandler = new ItemHandler();
        private TransactionLineHandler handler = new TransactionLineHandler();
        public TransactionLineForm()
        {
            InitializeComponent();
        }
        private void TransactionLineForm_Load(object sender, EventArgs e)
        {

            SetControlProperties();
            PopulateGrid();
        }

        private async Task PopulateGrid()
        {
            bsTransLine.DataSource = await handler.PopulateDataGridView();
            grvTransLine.DataSource = bsTransLine;
        }
        private async void SetControlProperties()
        {
            var dbItems = await itHandler.PopulateDataGridView();
            cmbItem.DataSource = new BindingSource(dbItems, null);
            cmbItem.DisplayMember = "Description";
            cmbItem.ValueMember = "ID";
            grvTransLine.Columns["clmID"].Visible = false;
        }

        #region Buttons
        private async void btnSave_Click(object sender, EventArgs e)
        {
            int itemId = (int)cmbItem.SelectedValue;
            Task<decimal> task = GetItemPrice(itemId);
            decimal itemPrice = await task;
            TransactionLineEditDto transLine = new TransactionLineEditDto
            {
                TransactionID = Int32.Parse(textBox1.Text),
                ItemID = itemId,
                Quantity = Int32.Parse(textBox3.Text),
                ItemPrice = itemPrice,
                NetValue = (Int32.Parse(textBox3.Text) * itemPrice),
                DiscountPercent = 0.2m,//decimal.Parse(textBox6.Text),
                DiscountValue = 0.3m,//decimal.Parse(textBox7.Text),
                TotalValue = 0.3m//decimal.Parse(textBox8.Text),

            };
            textBox1.Text = "";
            textBox3.Text = "";
            bsTransLine.Add(transLine);
            handler.AddTransactionLine(transLine);
        }
        #endregion

        private async Task<decimal> GetItemPrice(int id)
        {
            var dbItems = await itHandler.PopulateDataGridView();
            List<ItemEditDto> items = dbItems.ToList();
            
            decimal itemPrice = items.SingleOrDefault(it => it.ID == id).Price;
            return itemPrice;
        }

    }
}
