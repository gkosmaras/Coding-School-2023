using System.Data;
using System.Text.RegularExpressions;

namespace Calculator_Library
{
    public class Calculator
    {
        public string Calc(string x)
        {
            string result;
            try
            {
                DataTable dataTable = new DataTable();
                result = dataTable.Compute(x, "").ToString();
            }
            catch(Exception)
            {
                result = "Invalid input";
            }
            return result;
;
        }
        public string Rooter(string x)
        {
            string result;
            try
            {
                result = Math.Sqrt(Convert.ToDouble(x)).ToString();
            }
            catch(Exception)
            {
                result = "Can't be negative";
            }
            return result;

        }
        public object Parser(string x, string y)
        {
            if (int.TryParse(x, out int value))
            {
                y += x;
            }
            else
            {
                var regex = new Regex(@"(\d$)|([.]$)|(^$)");
                if (regex.Match(y).Success)
                {
                    y += x;
                }
                else
                {
                    y = y.Remove(y.Length - 1, 1);
                    y += x;
                }
            }
            return y;
        }
    }
}