using System.Data;

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
    }
}