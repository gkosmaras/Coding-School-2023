using System.Data;

namespace Calculator_Library
{
    public class Calculator
    {
        public object Calc(string x)
        {
            DataTable dataTable = new DataTable();
            return dataTable.Compute(x, "");
        }
    }
}