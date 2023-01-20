using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10.Libraries
{
    public class Filler
    {
        public University University { get; set; }
        private int _cntSchedule = 0;
        public Filler()
        {
            University = new University();
            University.Students = new List<Student>();
            University.Courses = new List<Course> { };
            University.Grades = new List<Grade> { };
            University.Professors = new List<Professor> { };
            University.Schedules = new List<Schedule> { };
        }
        public void PassCourse(Guid courseID, Guid professorID, DateTime time)
        {
            University.Schedules[_cntSchedule] = new Schedule(courseID, professorID, time);
        }


        public University Populate()
        {
            Random ran = new Random();
            University.Courses.Add(new Course("101", "Elementary physics"));
            University.Courses.Add(new Course("102", "Intermediate physics"));
            University.Courses.Add(new Course("103", "Advanced physics"));
            University.Professors.Add(new Professor("Prof.1", 30, "1", University.Courses));
            University.Professors.Add(new Professor("Prof.2", 60, "2", University.Courses));
            University.Professors.Add(new Professor("Prof.3", 90, "3", University.Courses));
            University.Students.Add(new Student("Student 1", 20, 11111, University.Courses));
            University.Students.Add(new Student("Student 2", 40, 22222, University.Courses));
            University.Students.Add(new Student("Student 3", 60, 33333, University.Courses));

            for (int i = 0; i < University.Courses.Count(); i++)
            {
                University.Schedules.Add(new Schedule(University.Courses[i].ID, University.Professors[ran.Next(0, 1)].ID, DateTime.Now));
            }
            for (int i = 0; i < University.Courses.Count(); i++)
            {
                for (int j = 0; j < University.Students.Count(); j++)
                {

                    University.Grades.Add(new Grade(University.Courses[i].ID, University.Students[i].ID, ran.Next(5, 10)));
                }
            }
            return University;
        }
    }
}
