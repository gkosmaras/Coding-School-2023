using FuelStation.EF.Context;
using FuelStation.Model;
using FuelStation.Model.Enums;
using FuelStation.Web.Blazor.Shared.Validators;
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

namespace FuelStation.Win
{
    public partial class ItemForm : Form
    {
        private FuelStationDbContext context = new FuelStationDbContext();
        private Validator validator = new Validator();
        public ItemForm()
        {
            InitializeComponent();
        }
        private void ItemForm_Load(object sender, EventArgs e)
        {
            SetControlProperties();
            PopulateItems();
            foreach(var value in Enum.GetValues(typeof(ItemType)))
            {
                cmbType.Items.Add(value.ToString());
            }
        }

        private void PopulateItems()
        {
            bsItem.DataSource = context.Items.ToList();
            grvItem.DataSource = bsItem;
        }
        private void SetControlProperties()
        {
            grvItem.AutoGenerateColumns = false;
            grvItem.DataSource = bsItem;
            grvItem.Columns["clmID"].Visible = false;
            DataGridViewComboBoxColumn colbox = grvItem.Columns["clmItemType"] as DataGridViewComboBoxColumn;
            foreach (var value in Enum.GetValues(typeof(ItemType)))
            {
                colbox.Items.Add(value);
            }
        }

        #region Buttons' Control
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Proceed with item deletion?", "Error", MessageBoxButtons.YesNo);
            if (dResult == DialogResult.Yes)
            {
                int id = (int)grvItem.CurrentRow.Cells["clmID"].Value;
                var itemDelete = context.Items.SingleOrDefault(it => it.ID == id);
                context.Remove(itemDelete);
                context.SaveChanges();
                PopulateItems();
            }
            else
            {
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
            
            Item item = new Item
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
            context.Items.Add(item);
            context.SaveChanges();
            PopulateItems();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string errorMessage = "Success";
            Item item = (Item)bsItem.Current;
            var dbItem = context.Items.Where(it => it.ID == item.ID).SingleOrDefault(); 
            if(validator.StringCheck(item.Code.ToString(), item.Description))
            {
                MessageBox.Show("Item's code & description can not be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!validator.ValidateCode(item.Code, item.ID))
            {
                MessageBox.Show("Item's code already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (validator.DecCheck(item.Price, item.Cost))
            {
                MessageBox.Show("Item's price & cost can not be negative", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            context.SaveChanges();

        }


        #endregion
    }
}
