using FuelStation.EF.Context;
using FuelStation.Model;
using FuelStation.Model.Enums;
using FuelStation.Web.Blazor.Shared.DTO;
using FuelStation.Web.Blazor.Shared.Validators;
using FuelStation.Win.Handler;
using Syncfusion.Blazor.PivotView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FuelStation.Win
{
    public partial class ItemForm : Form
    {
        private Validator validator = new Validator();
        private ItemHandler handler = new ItemHandler();
        private TransactionLineHandler transHandler = new TransactionLineHandler();
        public ItemForm()
        {
            InitializeComponent();
        }
        private async void ItemForm_Load(object sender, EventArgs e)
        {
            SetControlProperties();
            await PopulateGrid();
        }

        private async Task PopulateGrid()
        {
            bsItem.DataSource = await handler.PopulateDataGridView();
            grvItem.DataSource = bsItem;
        }
        private void SetControlProperties()
        {
            grvItem.Columns["clmID"].Visible = false;
            nudCode.Controls.RemoveAt(0);
            nudPrice.Controls.RemoveAt(0);
            nudPrice.DecimalPlaces = 2;
            nudCost.Controls.RemoveAt(0);
            nudCost.DecimalPlaces = 2;
            ClearText();

            DataGridViewComboBoxColumn colbox = grvItem.Columns["clmItemType"] as DataGridViewComboBoxColumn;
            foreach (var value in Enum.GetValues(typeof(ItemType)))
            {
                colbox.Items.Add(value);
                cmbType.Items.Add(value.ToString());
            }
        }

        private void ClearText()
        {
            lblDetail.Text = "";
            lblSum.Text = "";
            lblQnt.Text = "";
            lblCount.Text = "";
        }
        #region Buttons
        private async void btnSave_Click(object sender, EventArgs e)
        {
            string errorMessage = "Succces";
            if (validator.StringCheck(txtDescription.Text, txtDescription.Text))
            {
                MessageBox.Show("Description can not be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (validator.DecCheck(nudPrice.Value, nudCost.Value))
            {
                MessageBox.Show("Item's price & cost can not be negative", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!validator.ValidateAddItem((int)nudCode.Value, out errorMessage))
            {
                MessageBox.Show("Item's code already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbType.Text == "")
            {
                MessageBox.Show("Choose an item type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ItemEditDto item = new ItemEditDto
            {
                Code = (int)nudCode.Value,
                Description = txtDescription.Text,
                ItemType = (ItemType)Enum.Parse(typeof(ItemType), cmbType.Text),
                Price = nudPrice.Value,
                Cost = nudCost.Value,
            };
            nudCode.Value = 0;
            txtDescription.Text = "";
            cmbType.SelectedText = "";
            nudPrice.Value = 0;
            nudCost.Value = 0;
            bsItem.Add(item);
            await handler.AddItem(item);
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            ItemEditDto item = (ItemEditDto)bsItem.Current;
            if (validator.StringCheck(item.Code.ToString(), item.Description))
            {
                MessageBox.Show("Item's code & description can not be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (validator.DecCheck(item.Price, item.Cost))
            {
                MessageBox.Show("Item's price & cost can not be negative", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            await handler.EditItem(item);
            await PopulateGrid();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Proceed with item deletion?", "Error", MessageBoxButtons.YesNo);
            if (dResult == DialogResult.Yes)
            {
                int id = (int)grvItem.CurrentRow.Cells["clmID"].Value;
                await handler.DeleteItem(id);
                await PopulateGrid();
            }
            else
            {
                return;
            }
        }

        #endregion
        #region Events
        private async void grvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearText();
            var row = grvItem.CurrentRow;
            var item = (ItemEditDto)row.DataBoundItem;
            if (item != null)
            {
                var dbTransLines = await transHandler.PopulateDataGridView();
                var valueSold = dbTransLines
                    .Where(tLine => tLine.ItemID == item.ID)
                    .Sum(x => x.TotalValue);
                var qntSold = dbTransLines
                    .Where(tLine => tLine.ItemID == item.ID)
                    .Sum(x => x.Quantity);
                var timesSold = dbTransLines
                    .Where(tLine => tLine.ItemID == item.ID)
                    .Count();
                lblDetail.Text = $"Details for item {item.Description} with code {item.Code}";
                if (valueSold == 0)
                {
                    lblSum.Text = "This item has not been sold";
                }
                else
                {
                    lblSum.Text = $"Total value of transactions involving this item: {valueSold}€";
                    lblQnt.Text = $"This item has been sold {qntSold} times";
                    lblCount.Text = $"{timesSold} transactions involved this item";
                }
            }
        }
        #endregion
    }
}
