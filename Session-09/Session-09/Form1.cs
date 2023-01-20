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
            calculation = clickAction(calculation, sender);
            textBox.Text = calculation;
        }

        public void buttonSqrt(object sender, EventArgs e)
        {
            calculation = rootAction(calculation);
            textBox.Text = calculation;
        }
        public void buttonEqual(object sender, EventArgs e)
        {
            calculation = equalAction(calculation);
            textBox.Text = calculation;

        }
        public void buttonClear(object sender, EventArgs e)
        {
            calculation = string.Empty;
            textBox.Text = calculation;
        }


        public string clickAction(string calc, object s)
        {
            string entry = (s as Button).Text;
            Calculator result = new Calculator();
            calc = result.Parser(entry, calc).ToString();
            calc = result.Replacer(calc);
            return calc;
        }
        public string rootAction(string calc)
        {
            string answer;
            Calculator result = new Calculator();
            answer = result.Calc(calc);
            calc = result.Rooter(answer);
            calc = result.Replacer(calc);
            return calc;

        }
        public string equalAction(string calc)
        {
            Calculator result = new Calculator();

            if (calc.Contains("^"))
            {
                calc = result.Power(calc);
            }
            else
            {
                calc = result.Calc(calc);
            }
            calc = result.Replacer(calc);
            return calc;
        }
    }
}