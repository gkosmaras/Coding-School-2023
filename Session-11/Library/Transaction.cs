using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library {
    public class Transaction {
        public enum MethodPayment {
            Cash,
            Credit_Card
        };
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
        public Guid CustomerID { get; set; }
        public Guid EmployeeID { get; set; }
        public MethodPayment TypeOfPayment { get; set; }
        public decimal Cost { get; set; }
        public decimal TotalPrice { get; set; }

        public Transaction() {
            ID = Guid.NewGuid();
            Date = DateTime.Now;
        }
    }
}
