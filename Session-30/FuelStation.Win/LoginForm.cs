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
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginFrom_Load(object sender, EventArgs e)
        {
            btnMangerLg.Visible = true;
            btnCashierLg.Visible = true;
            btnStaffLg.Visible = true;
            btnCustomers.Visible = false;
            btnItems.Visible = false;
            btnLogout.Visible = false;
        }
        private void btnManagerLg_Click(object sender, EventArgs e)
        {
            HideLogins();
            btnCustomers.Visible = true;
            btnItems.Visible = true;
            btnLogout.Visible = true;
        }
        private void btnCashier_Click(object sender, EventArgs e)
        {
            HideLogins();
            btnCustomers.Visible = true;
            btnLogout.Visible = true;
        }
        private void btnStaff_Click(object sender, EventArgs e)
        {
            HideLogins();
            btnItems.Visible = true;
            btnLogout.Visible = true;
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
        private void HideLogins()
        {
            btnMangerLg.Visible = false;
            btnCashierLg.Visible = false;
            btnStaffLg.Visible = false;
        }
        #endregion
    }
}
