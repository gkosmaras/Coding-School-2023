using Beings;
using Lessons;

namespace Students
{
    public class Student : Person
    {
        public int RegistrationNumber { get; set; }
        public Courses[] Courses { get; set; }
        public Student()
        {

        }
        public Student(Guid id)
            : base(id)
        {

        }
        public Student(Guid id, string name)
            : base(id, name)
        {

        }
        public Student(Guid id, string name, int age)
            : base(id, name, age)
        {

        }
        public Student(Guid id, string name, int age, int registrationnumber)
            : base(id, name, age)
        {
            registrationnumber = RegistrationNumber;
        }
        public Student(Guid id, string name, int age, int registrationnumber, Courses[] courses)
            : base(id, name, age) 
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
