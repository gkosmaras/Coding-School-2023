using FuelStation.Web.Blazor.Shared.DTO;
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
    public partial class LoginForm : Form
    {
        private EmployeeHandler handler = new EmployeeHandler();
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginFrom_Load(object sender, EventArgs e)
        {
            SetVisibility();
            TextConfigurations();
        }
        private void SetVisibility()
        {
            btnEnter.Visible = true;
            btnCustomers.Visible = false;
            btnItems.Visible = false;
            btnTransaction.Visible = false;
            btnLogout.Visible = false;
        }
        private void TextConfigurations()
        {
            txtUsername.Text = "";
            txtUsername.MaxLength= 40;
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength= 14;
        }
        private async void btnEnter_Click(object sender, EventArgs e)
        {
            var dbEmployee = await handler.PopulateDataGridView();
            string input = txtPassword.Text.Remove(0,8);
            Int32.TryParse(input, out int result);
            string username = txtUsername.Text;
            var user = (dbEmployee.SingleOrDefault(x => x.ID == result));
            if (user == null)
            {
                MessageBox.Show("Wrong credentials!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextConfigurations();
                return;
            }
            if (username == (user.Name + user.Surname).ToLower()
                && user.ID == result)
            {
                btnEnter.Visible = false;
                if (user.EmployeeType == Model.Enums.EmployeeType.Manager)
                {
                    btnCustomers.Visible = true;
                    btnItems.Visible = true;
                    btnTransaction.Visible = true;
                    btnLogout.Visible = true;
                }
                else if (user.EmployeeType == Model.Enums.EmployeeType.Cashier)
                {
                    btnCustomers.Visible = true;
                    btnTransaction.Visible = true;
                    btnLogout.Visible = true;
                }
                else
                {
                    btnItems.Visible = true;
                    btnLogout.Visible = true;
                }
            }
            else if (username == "admin" && txtPassword.Text == "sysadmin")
            {
                btnEnter.Visible = false;
                btnCustomers.Visible = true;
                btnItems.Visible = true;
                btnTransaction.Visible = true;
                btnLogout.Visible = true;
            }
        }
        private void btnLogout_CLick(object sender, EventArgs e)
        {
            TextConfigurations();
            SetVisibility();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.FormClosed += new FormClosedEventHandler(customerForm_FormClosed);
            this.Hide();
            customerForm.ShowDialog();
        }
        private void btnItems_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();
            itemForm.FormClosed += new FormClosedEventHandler(itemForm_FormClosed);
            this.Hide();
            itemForm.ShowDialog();
        }
        private void btnTransactions(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.FormClosed += new FormClosedEventHandler(transactionForm_FormClosed);
            this.Hide();
            transactionForm.ShowDialog();
        }
        #region Visiblity
        private void customerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void itemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void transactionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        #endregion
    }
}
