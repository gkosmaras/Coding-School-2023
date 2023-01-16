using Beings;
using Lessons;

namespace Teachers
{
    public class Professor : Person
    {
        public string? Rank { get; set; }
        public Courses[] Courses { get; set; }

        public Professor()
        {

        }
        public Professor(Guid id)
            : base(id)
        {

        }
        public Professor(Guid id, string name)
            : base(id, name)
        {

        }
        public Professor(Guid id, string name, int age)
            : base(id, name, age)
        {

        }
        public Professor(Guid id, string name, int age, string rank)
            : base(id, name, age)
        {
            Rank = rank;
        }
        public Professor(Guid id, string name, int age, string rank, Courses[] courses)
            : base(id, name, age)
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
}
