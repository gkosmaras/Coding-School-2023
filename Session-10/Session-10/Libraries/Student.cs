using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10.Libraries
{
    public class Person
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        
        public Person()
        {
            ID = Guid.NewGuid();
        }
    }
    public class Student : Person
    {
        public int RegistrationNumber { get; set; }
    }
}
