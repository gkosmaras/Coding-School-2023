using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EF.Course.Model
{
    public class Todo
    {
        public Todo(string title)
        {
            Title = title;
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public bool Finished { get; set; }
    }
}
