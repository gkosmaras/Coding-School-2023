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
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            DataGridViewComboBoxColumn colbox = grvTransLine.Columns["clmItemID"] as DataGridViewComboBoxColumn;
            colbox.DataSource = new BindingSource(dbItems, null);
            colbox.DisplayMember = "Description";
            colbox.ValueMember = "ID";

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

            TransactionLineEditDto transLine = new TransactionLineEditDto
            {
                TransactionID = Int32.Parse(textBox1.Text),
                ItemID = itemId,
                Quantity = qnt
            };
            textBox1.Text = "";
            nudQuantity.Value = 0;
            bsTransLine.Add(transLine);
            handler.AddTransactionLine(transLine);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TransactionLineEditDto transLine = (TransactionLineEditDto)bsTransLine.Current;
            if (transLine.Quantity <= 0)
            {
                MessageBox.Show("Enter a meaningfull quantity of products", "Error", MessageBoxButtons.OK);
                return;
            }
            handler.EditTransactionLine(transLine);
            bsTransLine.ResetCurrentItem();

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
        private void dataGridView1_CellValidating(object sender,
                                               DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int i;

                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("Quantity can only be numeric", "Error");
                }
            }
        }
    }
}
