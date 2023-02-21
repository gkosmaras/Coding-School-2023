using FuelStation.Web.Blazor.Shared.DTO;
using FuelStation.Web.Blazor.Shared.Validators;
using FuelStation.Win.Handler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Win
{
    public partial class CreateCustomerForm : Form
    {
        private Validator validator = new Validator();
        private CustomerHandler handler = new CustomerHandler();
        public CreateCustomerForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validator.StringCheck(txtName.Text, txtSurname.Text))
            {
                MessageBox.Show("Names can not be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CustomerEditDto customer = new CustomerEditDto
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                CardNumber = validator.GetCardNumber()
            };
            txtName.Text = "";
            txtSurname.Text = "";
            handler.AddCustomer(customer);
            this.Close();
        }
    }
}
