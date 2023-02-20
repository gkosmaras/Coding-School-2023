using FuelStation.EF.Context;
using FuelStation.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared
{
    public class CardGenerator
    {
        private FuelStationDbContext context = new FuelStationDbContext();
        public string GetCardNumber()
        {
            Random generator = new Random();
        Generate:
            string cn = generator.Next(0, 10000000).ToString("D7");
            cn = string.Concat("A-", cn);
            if (CheckCardUniqueness(cn))
            {
                goto Generate;
            }
            return cn;
        }

        public bool CheckCardUniqueness(string cn)
        {
            var dbCustomer = context.Customers.Select(cus => cus.CardNumber);
            bool result = dbCustomer.Contains(cn);
            return result;
        }
    }
}
