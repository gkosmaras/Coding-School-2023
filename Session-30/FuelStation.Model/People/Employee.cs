using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.People
{
    public class Employee : Person
    {
        public DateTime HireDateStart = DateTime.Now;
        public DateTime HireDateEnd {get;set;}
        public decimal? SalaryPerMonth { get;set;}
        public EmployeeType EmployeeType { get;set;}
    }
}
