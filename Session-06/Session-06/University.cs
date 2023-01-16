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

namespace Session_06
{
    public class University : Institute
    {
        Student[] Students { get; set; }
        Courses[] Courses { get; set; }
        Grades[] Grade { get; set; }
        Schedule[] ScheduledCourse { get; set; }

        public University()
        {

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
