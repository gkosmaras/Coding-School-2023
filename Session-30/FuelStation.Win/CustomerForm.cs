using FuelStation.EF.Context;
using FuelStation.EF.Repositories;
using FuelStation.Model.People;
using FuelStation.Web.Blazor.Shared;
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
    public partial class CustomerForm : Form
    {
        private FuelStationDbContext context = new FuelStationDbContext();
        public CustomerForm()
        {
            InitializeComponent();
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            grvCustomer.DataSource = context.Customers.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LoadOptions();
            grvCustomer.DataSource = null;
            grvCustomer.DataSource = context.Customers.ToList();
        }

        private void LoadOptions()
        {
            CardGenerator card = new CardGenerator();
            context.Customers.Add(new Customer
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                CardNumber = card.GetCardNumber()
            });
            txtName.Text = "";
            txtSurname.Text = "";
            context.SaveChanges();
        }

        private void grvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = grvCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            MessageBox.Show(id);
        }
    }
}
