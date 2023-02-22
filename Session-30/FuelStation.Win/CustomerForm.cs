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
        private async void CustomerForm_Load(object sender, EventArgs e)
        {
            await PopulateGrid();
        }

        private async Task PopulateGrid()
        {
            grvCustomer.Columns["clmID"].Visible = false;
            grvCustomer.Columns["clmCardNumber"].ReadOnly = true;
            bsCustomer.DataSource = await handler.PopulateDataGridView();
            grvCustomer.DataSource = null;
            grvCustomer.DataSource = bsCustomer;
        }

        #region Buttons
        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateCustomerForm newCustomer = new CreateCustomerForm();
            newCustomer.FormClosing += new FormClosingEventHandler(this.CreateCustomer_FormClosing);
            newCustomer.ShowDialog();
            
            
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            CustomerEditDto customer = (CustomerEditDto)bsCustomer.Current;
            if (validator.StringCheck(customer.Name, customer.Surname))
            {
                MessageBox.Show("Customer's name & surname can not be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            await handler.EditCustomer(customer);
            await PopulateGrid();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Proceed with customer deletion?", "Warning", MessageBoxButtons.YesNo);
            if (dResult == DialogResult.Yes)
            {
                int id = (int)grvCustomer.CurrentRow.Cells["clmID"].Value;
                await handler.DeleteCustomer(id);
                await PopulateGrid();
            }
            else
            {
                return;
            }
        }

        private async void CreateCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            await PopulateGrid();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
