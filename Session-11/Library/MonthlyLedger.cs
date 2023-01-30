using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class MonthlyLedger
    {
        //Properties
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }

        //Constructors
        public MonthlyLedger() 
        {
            Year = DateTime.Now.Year;
            Month = DateTime.Now.Month;
        }
    }
}
