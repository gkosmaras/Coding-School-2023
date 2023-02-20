using FuelStation.EF.Context;
using FuelStation.EF.Repositories;
using FuelStation.Model.People;
using FuelStation.Web.Blazor.Shared;
using FuelStation.Web.Blazor.Shared.Validators;
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
        private Validator validator = new Validator();
        public CustomerForm()
        {
            InitializeComponent();
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            SetControlProperties();
            PopulateCustomers();
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
            grvCustomer.Columns["clmID"].Visible = false;
        }

        #region Buttons' Control
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Proceed with customer deletion?", "Error", MessageBoxButtons.YesNo);
            if (dResult == DialogResult.Yes)
            {
                int id = (int)grvCustomer.CurrentRow.Cells["clmID"].Value;
                var customerDelete = context.Customers.SingleOrDefault(cus => cus.ID == id);
                context.Remove(customerDelete);
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
            if (validator.StringCheck(txtName.Text, txtSurname.Text))
            {
                MessageBox.Show("Names can not be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Customer customer = new Customer
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                CardNumber = validator.GetCardNumber()
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
            if (validator.StringCheck(customer.Name, customer.Surname))
            {
                MessageBox.Show("Customer's name & surname can not be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            context.SaveChanges();
            PopulateCustomers();
        }
        #endregion
    }
}
