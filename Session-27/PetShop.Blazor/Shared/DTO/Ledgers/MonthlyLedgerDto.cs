using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Blazor.Shared.DTO.Ledgers
{
    public class MonthlyLedgerDto
    {
        public int Year { get ; set; }
        public string Month { get; set; } = null!;
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }
    }
}
