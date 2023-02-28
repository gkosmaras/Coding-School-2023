using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared.DTO
{
    public class ItemLedgerDto
    {
        public int Year { get; set; }
        public string Month { get; set; } = null!;
        public List<string> ItemNames { get; set; } = new();
        public List<int> ItemQnt { get; set; } = new();
    }
}
