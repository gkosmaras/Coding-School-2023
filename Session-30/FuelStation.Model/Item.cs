using FuelStation.Model.Enums;
using FuelStation.Model.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model
{
    public class Item : BaseEntity
    {
        public int Code { get; set; }
        public string Description { get; set; }
        public ItemType ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set;}
        public List<TransactionLine> TransactionLines { get; set; }
    }
}
