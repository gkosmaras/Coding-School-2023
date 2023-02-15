using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Blazor.Shared.DTO.Ledgers
{
    public class MonthlyLedgerDto
    {
        public DateTime Date { get ; set; }
        public decimal Income { get; set; }
    }
}
