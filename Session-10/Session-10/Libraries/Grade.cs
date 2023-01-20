using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10.Libraries
{
    public class Grade
    {
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int Score { get; set; }

        public Grade(Guid studentID, Guid courseID, int score)
        {
            ID = Guid.NewGuid();
            StudentID = studentID;
            CourseID = courseID;
            Score = score;
        }
    }
}
