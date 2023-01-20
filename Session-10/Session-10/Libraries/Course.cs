using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10.Libraries
{
    public class Course
    {
        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Subject { get; set; }
        
        public Course()
        {
            ID = Guid.NewGuid();
        }
    }
}
