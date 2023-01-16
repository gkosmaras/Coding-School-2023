using Beings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lessons;
using Score;
using Calendar;

namespace Institutes
{
    public class Institute
    {
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int YearsInService { get; set; }

        public Institute()
        {

        }
        public Institute(Guid id)
        {
            ID = id;
        }
        public Institute(Guid id, string name) : this(id)
        {
            Name = name;
        }
        public Institute(Guid id, string name, int years) : this(id, name)
        {
            YearsInService = years;
        }
        public void GetName()
        {

        }
        public void SetName(string name)
        {

        }
    }

    public class University : Institute
    {
        public Student[] Students { get; set; }
        public Courses[] Courses { get; set; }
        public Grades[] Grade { get; set; }
        public Schedule[] ScheduledCourse { get; set; }

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