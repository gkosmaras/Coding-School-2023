using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public  class Schedule
    {
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }
        public DateTime Calendar { get; set; }

        public Schedule()
        {

        }
        public Schedule(Guid id)
        {
            ID = id;
        }
        public Schedule(Guid id, Guid courseid)
            : this(id) 
        {
            CourseID = courseid;
        }
        public Schedule(Guid id, Guid courseid, Guid professorid)
            : this(id, courseid)
        {
            ProfessorID = professorid;
        }
        public Schedule(Guid id, Guid courseid, Guid professorid, DateTime calendar)
            : this(id, courseid, professorid)
        {
            Calendar = calendar;
        }
    }
}
