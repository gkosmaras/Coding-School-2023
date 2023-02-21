using FuelStation.EF.Context;
using FuelStation.Model.Enums;
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
            nudQuantity.Controls.RemoveAt(0);
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
            int qnt = (int)nudQuantity.Value;
            if (qnt <= 0)
            {
                MessageBox.Show("Enter a meaningfull quantity of products", "Error", MessageBoxButtons.OK);
                return;
            }
            Task<decimal> taskPrice = GetItemPrice(itemId);
            decimal itemPrice = await taskPrice;
            Task<decimal> taskDiscount = CheckDiscount(itemId, itemPrice, qnt);
            decimal discount = await taskDiscount;
            decimal percent = 0;
            if (discount > 0)
            {
                percent = 20;
            }

            TransactionLineEditDto transLine = new TransactionLineEditDto
            {
                TransactionID = Int32.Parse(textBox1.Text),
                ItemID = itemId,
                Quantity = qnt,
                ItemPrice = itemPrice,
                NetValue = (qnt * itemPrice),
                DiscountPercent = percent,
                DiscountValue = (qnt * itemPrice) * discount,
                TotalValue = (qnt * itemPrice) - (qnt * itemPrice) * discount,
            };
            textBox1.Text = "";
            nudQuantity.Value = 0;
            bsTransLine.Add(transLine);
            handler.AddTransactionLine(transLine);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Proceed with line deletion?", "Warning", MessageBoxButtons.YesNo);
            if (dResult == DialogResult.Yes)
            {
                int id = (int)grvTransLine.CurrentRow.Cells["clmID"].Value;
                handler.DeleteTransactionLine(id);
                bsTransLine.RemoveCurrent();
            }
        }
        #endregion

        #region Methods
        private async Task<decimal> GetItemPrice(int id)
        {
            var dbItems = await itHandler.PopulateDataGridView();
            List<ItemEditDto> items = dbItems.ToList();
            
            decimal itemPrice = items.SingleOrDefault(it => it.ID == id).Price;
            return itemPrice;
        }
        private async Task<decimal> CheckDiscount(int id, decimal price, int qnt)
        {
            decimal discount = 0;
            var dbItems = await itHandler.PopulateDataGridView();
            List<ItemEditDto> items = dbItems.ToList();
            ItemType type = items.SingleOrDefault(it => it.ID == id).ItemType;
            if (type == ItemType.Fuel && (price * qnt) > 20)
            {
                discount = 0.2m;
            }
            return discount;
        }
        #endregion
    }
}
