using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10.Libraries
{
    public class Institute
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int YearsInService { get; set; }
        public Institute() 
        { 
            ID = Guid.NewGuid();
        }
    }
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
    public class University : Institute
    {
        public List<Student> Students { get; set; }
        public University()
        {
            Students = new List<Student>();
        }
    }
    public class Student : Person
    {
        public int RegistrationNumber { get; set; }
    }

}
