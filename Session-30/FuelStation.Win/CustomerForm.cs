using FuelStation.Web.Blazor.Shared.DTO;
using FuelStation.Web.Blazor.Shared.Validators;
using FuelStation.Win.Handler;

namespace FuelStation.Win
{
    public partial class CustomerForm : Form
    {
        private Validator validator = new Validator();
        private CustomerHandler handler = new CustomerHandler();
        private TransactionHandler transHandler = new TransactionHandler();

        public CustomerForm()
        {
            InitializeComponent();
        }

        private async void CustomerForm_Load(object sender, EventArgs e)
        {
            SetControlProperties();
            await PopulateGrid();
        }

        private async Task PopulateGrid()
        {

            bsCustomer.DataSource = await handler.PopulateDataGridView();
            grvCustomer.DataSource = null;
            grvCustomer.DataSource = bsCustomer;
        }

        private void SetControlProperties()
        {
            grvCustomer.AutoGenerateColumns = false;
            grvCustomer.Columns["clmID"].Visible = false;
            grvCustomer.Columns["clmCardNumber"].ReadOnly = true;
            ClearText();
        }

        private void ClearText()
        {
            lblName.Text = "";
            lblTotal.Text = "";
            lblDate.Text = "";
        }

        #region Buttons
        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateCustomerForm newCustomer = new CreateCustomerForm();
            newCustomer.FormClosing += new FormClosingEventHandler(this.CreateCustomerForm_FormClosing);
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

        #endregion
        #region Events
        private async void grvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearText();
            var row = grvCustomer.CurrentRow;
            var customer = (CustomerEditDto)row.DataBoundItem;
            if (customer != null)
            {
                var dbTransactions = await transHandler.PopulateDataGridView();
                var lastDate = dbTransactions
                    .Where(trans => trans.CustomerID == customer.ID)
                    .Select(x => x.Date).LastOrDefault();
                var total = dbTransactions
                    .Where(trans => trans.CustomerID == customer.ID)
                    .Sum(x => x.TotalValue);
                lblName.Text = $"Details for {customer.Name} {customer.Surname}";
                if (total == 0)
                {
                    lblTotal.Text = "This customer has no transactions";

                }
                else
                {
                    lblTotal.Text = $"Total transactions value: {total}€";
                    lblDate.Text = $"Last purchase date: {lastDate}";
                }
            }
        }

        private async void CreateCustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            await PopulateGrid();
        }
        #endregion
    }
}
