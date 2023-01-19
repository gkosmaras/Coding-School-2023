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
            Calculator result = new Calculator();
            calculation = result.Parser(entry, calculation).ToString();
            calculation = result.Replacer(calculation);
            textBox.Text = calculation;
        }

        public void buttonSqrt(object sender, EventArgs e)
        {
            string answer;
            Calculator result = new Calculator();
            answer = result.Calc(calculation);
            calculation = result.Rooter(answer);
            calculation = result.Replacer(calculation);
            textBox.Text = calculation;
        }
        public void buttonEqual(object sender, EventArgs e)
        {
            Calculator result = new Calculator();

            if (calculation.Contains("^"))
            {
                calculation = result.Power(calculation);
            }
            else
            {
                calculation = result.Calc(calculation);
            }
            calculation = result.Replacer(calculation);
            textBox.Text = calculation;

        }
        public void buttonClear(object sender, EventArgs e)
        {
            calculation = string.Empty;
            textBox.Text = calculation;
        }
    }
}