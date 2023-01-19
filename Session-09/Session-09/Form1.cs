using System.Data;
using System.Xml.Serialization;
using Calculator_Library;

namespace Session_09
{
    public partial class Form1 : Form
    {
        private string calculation = string.Empty;
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
            Calculator result = new Calculator();
            textBox.Text = result.Calc(calculation).ToString();
            calculation = string.Empty;
        }
    }
}