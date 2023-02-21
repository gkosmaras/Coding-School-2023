using FuelStation.EF.Context;
using FuelStation.Model;
using FuelStation.Model.Enums;
using FuelStation.Web.Blazor.Shared.DTO;
using FuelStation.Web.Blazor.Shared.Validators;
using FuelStation.Win.Handler;
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
        public ItemForm()
        {
            InitializeComponent();
        }
        private void ItemForm_Load(object sender, EventArgs e)
        {
            SetControlProperties();
            PopulateGrid();
        }

        private async Task PopulateGrid()
        {
            bsItem.DataSource = await handler.PopulateDataGridView();
            grvItem.DataSource = bsItem;
        }
        private void SetControlProperties()
        {
            grvItem.Columns["clmID"].Visible = false;
            DataGridViewComboBoxColumn colbox = grvItem.Columns["clmItemType"] as DataGridViewComboBoxColumn;
            foreach (var value in Enum.GetValues(typeof(ItemType)))
            {
                colbox.Items.Add(value);
            }
            foreach (var value in Enum.GetValues(typeof(ItemType)))
            {
                cmbType.Items.Add(value.ToString());
            }
        }

        #region Buttons
        private void btnSave_Click(object sender, EventArgs e)
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
            handler.AddItem(item);
        }

        private void btnEdit_Click(object sender, EventArgs e)
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
            handler.EditItem(item);
            bsItem.ResetCurrentItem();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Proceed with item deletion?", "Error", MessageBoxButtons.YesNo);
            if (dResult == DialogResult.Yes)
            {
                int id = (int)grvItem.CurrentRow.Cells["clmID"].Value;
                handler.DeleteItem(id);
                bsItem.RemoveCurrent();
            }
            else
            {
                return;
            }
        }
        #endregion
    }
}
