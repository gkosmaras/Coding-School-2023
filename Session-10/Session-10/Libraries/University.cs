using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session_10.Libraries;

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
    public class University : Institute
    {
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<Grade> Grades { get; set; }
        public List<Professor> Professors { get; set; }
        public List<Schedule> Schedules { get; set; }
        public University()
        {
            Students = new List<Student>();
            Courses = new List<Course>();
            Grades = new List<Grade>();
            Professors = new List<Professor>();
            Schedules = new List<Schedule>();

        }
    }
}
