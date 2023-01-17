using Calendar;
using Institutes;
using Lessons;
using Score;
using Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni
{
    public class University : Institute
    {
        public Student[] Students { get; set; }
        public Courses[] Courses { get; set; }
        public Grades[] Grade { get; set; }
        public Schedule[] ScheduledCourse { get; set; }

        public University()
        {
            Students = new Student[20];
        }
        public University(Guid id)
            : base(id)
        {

        }
        public University(Guid id, string name)
            : base(id, name)
        {

        }
        public University(Guid id, string name, int years, Student[] students)
            : base(id, name, years)
        {
            Students = students;
        }
        public University(Guid id, string name, int years, Student[] students, Courses[] courses)
            : base(id, name, years)
        {
            Students = students;
            Courses = courses;
        }
        public University(Guid id, string name, int years, Student[] students, Courses[] courses, Grades[] grades)
            : base(id, name, years)
        {
            Students = students;
            Courses = courses;
            Grade = grades;
        }
        public University(Guid id, string name, int years, Student[] students, Courses[] courses, Grades[] grades, Schedule[] schedules)
            : base(id, name, years)
        {
            Students = students;
            Courses = courses;
            Grade = grades;
            ScheduledCourse = schedules;
        }
        public void GetStudents()
        {

        }
        public void GetCourses()
        {

        }
        public void GetGrades()
        {

        }
        public void SetSchedule(Guid courseId, Guid professorID, DateTime datetime)
        {

        }
    }
}
