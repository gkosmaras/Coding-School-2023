using System;
using static Library.Product;

namespace Library
{
    public enum EmployeeType
    {
        Manager,
        Cashier,
        Barista,
        Waiter
    }

    public class Employee
    {
       //Properties
       public Guid ID { get; set; }
       public string Name { get; set; }
       public string Surname { get; set; }
       
       // public enum EmployeeType { get; set; }
       public EmployeeType TypeOfEmployee { get; set; }

       //public List<Employee>? employees;


        public decimal SalaryPerMonth { get; set; }

        //Constructors
        public Employee()
        {
            ID = Guid.NewGuid();
        }
    }

    /* Each shop should have: 1 Manager, 1-2 Cashiers, 1-2 Baristas and 1-3 Waiters */

  

    
   

    //Methods
}

