using System.Data;
using System.Xml.Serialization;

namespace Session_09
{
    public partial class Form1 : Form
    {
        private string calculation = "";
        public Form1()
        {
            InitializeComponent();
        }

        public void buttonClick(object sender, EventArgs e)
        {
            calculation += (sender as Button).Text;
            textBox.Text = calculation;
        }
        public void buttonEqual(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            textBox.Text = (dataTable.Compute(calculation, "")).ToString();
            calculation = "";
        }
    }
}