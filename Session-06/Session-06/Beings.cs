using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lessons;

namespace Beings
{
    public class Person
    {
        // 3 Properties
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        
        // Constructors
        public Person()
        {

        }
        public Person(Guid id)
        {
            ID = id;
        }
        public Person(Guid id, string name) : this (id)
        {
            Name = name;
        }
        public Person(Guid id, string name, int age) : this (id, name)
        {;
            Age = age;
        }

        public void GetName()
        {

        }
        public void SetName(string name)
        {

        }
    }

    public class Professor : Person
    {
        public string? Rank { get; set; }
        public Courses[] Courses { get; set; }

        public Professor()
        {

        }
        public Professor(Guid  id) : base(id)
        {

        }
        public Professor(Guid id, string name) : base(id, name)
        {

        }
        public Professor(Guid id, string name, int age) : base(id, name, age)
        {

        }
        public Professor(Guid id, string name, int age, string rank) : base(id, name, age)
        {
            Rank = rank;
        }
        public Professor(Guid id, string name, int age, string rank, Courses[] courses) : base(id, name, age)
        {
            Courses = courses;
        }

        public void Teach(Courses[] course, DateTime datetime)
        {

        }
        public void SetGrade(Guid StudentID, Guid courseID, int grade)
        {
            
        }
    }

    public class Student : Person
    {
        public int RegistrationNumber { get; set; }
        public Courses[] Courses { get; set; }
        public Student()
        {

        }
        public Student(Guid id) : base(id)
        {

        }
        public Student(Guid id, string name) : base(id, name)
        {

        }
        public Student(Guid id, string name, int age) : base(id, name, age)
        {

        }
        public Student(Guid id, string name, int age, int registrationnumber) : base(id, name, age)
        {
            registrationnumber = RegistrationNumber;
        }
        public Student(Guid id, string name, int age, int registrationnumber, Courses[] courses) : base(id, name, age)
        {
            registrationnumber = RegistrationNumber;
            Courses = courses;
        }

        public void Attend(Courses[] course, DateTime datetime)
        {

        }
        public void WriteExam(Courses[] course, DateTime datetime)
        {

        }
    }
}
