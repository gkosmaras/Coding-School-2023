using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    public class Courses
    {
        public Guid ID { get; set; }
        public string? Code { get; set; }
        public string? Subject { get; set; }

        public Courses()
        {

        }
        public Courses(Guid id)
        {
            ID = id;
        }
        public Courses(Guid id, string code) : this (id)
        {
            Code = code;
        }
        public Courses(Guid id, string code, string subject) : this (id, code)
        {
            Subject = subject;
        }
    }
}