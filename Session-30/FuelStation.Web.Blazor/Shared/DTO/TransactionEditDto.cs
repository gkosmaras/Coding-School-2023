using FuelStation.Model.Enums;
using FuelStation.Model.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared.DTO
{
    public class TransactionEditDto
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public decimal? TotalValue { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public List<TransactionLine> TransactionLines { get; set; } = null!;
    }
}
