using PetShop.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Blazor.Shared.DTO.Ledgers
{
    public class PetReportDto
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public List<string> AnimalTypes { get; set; } = new();
        public List<List<int>> TotalSold { get; set; } = new();
    }
}
