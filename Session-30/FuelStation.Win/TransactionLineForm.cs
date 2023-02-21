using FuelStation.Web.Blazor.Shared.DTO;
using FuelStation.Win.Handler;
using Syncfusion.Blazor.Diagrams;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FuelStation.Win
{
    public partial class TransactionLineForm : Form
    {
        private TransactionLineHandler handler = new TransactionLineHandler();
        public TransactionLineForm()
        {
            InitializeComponent();
        }
        private void TransactionLineForm_Load(object sender, EventArgs e)
        {
            //SetControlProperties();
            PopulateGrid();
        }

        private async Task PopulateGrid()
        {
            bsTransLine.DataSource = await handler.PopulateDataGridView();
            grvTransLine.DataSource = bsTransLine;
        }

        #region Buttons
        private void btnSave_Click(object sender, EventArgs e)
        {
            TransactionLineEditDto transLine = new TransactionLineEditDto
            {
                TransactionID = Int32.Parse(textBox1.Text),
                ItemID = Int32.Parse(textBox2.Text),
                Quantity = Int32.Parse(textBox3.Text),
                ItemPrice = decimal.Parse(textBox4.Text),
                NetValue = decimal.Parse(textBox5.Text),
                DiscountPercent = decimal.Parse(textBox6.Text),
                DiscountValue = decimal.Parse(textBox7.Text),
                TotalValue = decimal.Parse(textBox8.Text),

            };
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            bsTransLine.Add(transLine);
            handler.AddTransactionLine(transLine);
        }
        #endregion
    }
}
