using PetShop.Blazor.Shared.DTO.Transaction;
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
        public string Month { get; set; } = null!;
        public List<string> AnimalTypes { get; set; } = new();
        public int Bird { get; set; }
        public int Mammal { get; set; }
        public int Reptile { get; set; }
        public int Fish { get; set; }
    }
}
