using System.Data;
using System.Text.RegularExpressions;
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

        private void buttonClick(object sender, EventArgs e)
        {
            string entry = (sender as Button).Text;
            var regex = new Regex(@"(\d$)|([.]$)|(^$)");
            if (regex.Match(calculation).Success)
            {
                calculation += entry;
                textBox.Text = calculation;
            }
            else
            {
                calculation = calculation.Remove(calculation.Length - 1, 1);
                calculation += entry;
                textBox.Text = calculation;
            }
        }
        public void buttonEqual(object sender, EventArgs e)
        {
            Calculator result = new Calculator();
            textBox.Text = result.Calc(calculation).ToString();
            calculation = string.Empty;
        }
    }
}