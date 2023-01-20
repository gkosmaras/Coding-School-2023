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
        public List<Course> Courses;
        public Student(string name, int age, int registrationNumber, List<Course> courseList)
        {
            Name = name;
            Age = age;
            RegistrationNumber = registrationNumber;
            Courses = courseList;
        }
    }
    public class Professor : Person
    {
        public string Rank { get; set; }
        public List<Course> Courses;
        public Professor(string name, int age, string rank, List<Course> courseList)
        {
            Name = name;
            Age = age;
            Rank = rank;
            Courses = courseList;
        }
    }
}
