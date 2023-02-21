using FuelStation.Web.Blazor.Shared.DTO;
using FuelStation.Web.Blazor.Shared.Validators;
using FuelStation.Win.Handler;

namespace FuelStation.Win
{
    public partial class CustomerForm : Form
    {
        private Validator validator = new Validator();
        private CustomerHandler handler = new CustomerHandler();
        public CustomerForm()
        {
            InitializeComponent();
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private async Task PopulateGrid()
        {
            grvCustomer.Columns["clmID"].Visible = false;
            grvCustomer.Columns["clmCardNumber"].ReadOnly = true;
            bsCustomer.DataSource = await handler.PopulateDataGridView();
            grvCustomer.DataSource = bsCustomer;
        }

        private async Task bsCustomer_ListChange(object sender, EventArgs e)
        {
            bsCustomer.DataSource = await handler.PopulateDataGridView();
            grvCustomer.DataSource = bsCustomer;
        }

        #region Buttons
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
            bsCustomer.Add(customer);
            handler.AddCustomer(customer);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CustomerEditDto customer = (CustomerEditDto)bsCustomer.Current;
            if (validator.StringCheck(customer.Name, customer.Surname))
            {
                MessageBox.Show("Customer's name & surname can not be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            handler.EditCustomer(customer);
            bsCustomer.ResetCurrentItem();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Proceed with customer deletion?", "Error", MessageBoxButtons.YesNo);
            if (dResult == DialogResult.Yes)
            {
                int id = (int)grvCustomer.CurrentRow.Cells["clmID"].Value;
                handler.DeleteCustomer(id);
                bsCustomer.RemoveCurrent();
            }
            else
            {
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
