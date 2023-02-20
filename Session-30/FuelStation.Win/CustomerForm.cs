using FuelStation.EF.Context;
using FuelStation.EF.Repositories;
using FuelStation.Model.People;
using FuelStation.Web.Blazor.Shared;
using Newtonsoft.Json.Bson;
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
        BindingSource bindingSource = new BindingSource();
        public CustomerForm()
        {
            InitializeComponent();
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            PopulateCustomers();
            SetControlProperties();
        }

        private void PopulateCustomers()
        {
            bsCustomer.DataSource = context.Customers.ToList();
            grvCustomer.DataSource = bsCustomer;
        }
        private void SetControlProperties()
        {
            grvCustomer.AutoGenerateColumns = false;
            grvCustomer.DataSource = bsCustomer;
            grvCustomer.Columns["ID"].Visible = false;

        }

        #region Buttons' Control
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Proceed with customer deletion?", "Warning", MessageBoxButtons.YesNo);
            if (dResult == DialogResult.Yes)
            {
                int id = (int)grvCustomer.CurrentRow.Cells[3].Value;
                var temp = context.Customers.SingleOrDefault(cus => cus.ID == id);
                context.Remove(temp);
                context.SaveChanges();
                PopulateCustomers();
            }
            else
            {
                return;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            CardGenerator card = new CardGenerator();
            if (StringCheck(txtName.Text, txtSurname.Text))
            {
                MessageBox.Show("Names can not be null", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Customer customer = new Customer
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                CardNumber = card.GetCardNumber()
            };
            txtName.Text = "";
            txtSurname.Text = "";
            context.Customers.Add(customer);
            context.SaveChanges();
            PopulateCustomers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Customer customer = (Customer)bsCustomer.Current;
            if (StringCheck(customer.Name, customer.Surname))
            {
                MessageBox.Show("Customer's name & surname can not be deleted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            context.SaveChanges();
            PopulateCustomers();
        }
        #endregion
        private bool StringCheck(string name, string surname)
        {
            return (String.IsNullOrWhiteSpace(name) || String.IsNullOrWhiteSpace(surname));
        }
    }
}
