using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.People
{
    public class Customer : Person
    {
        public string CardNumber { get; set; }
    }
}
