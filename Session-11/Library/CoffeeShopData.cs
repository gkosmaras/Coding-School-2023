using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class CoffeeShopData
    {

        // properties
        public List<Product> products { get; set; }
        public List<Employee> employees { get; set; }
        public List<TransactionLine> transactionLines { get; set; }
        public List<Transaction> transactions{ get; set; }




        // constructors
        public CoffeeShopData()
        {
            products = new List<Product>();
            employees = new List<Employee>();
            transactionLines = new List<TransactionLine>();
            transactions = new List<Transaction>();
        }
    }
}

