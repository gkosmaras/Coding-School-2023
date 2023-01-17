using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public class ActionRequest : ActionResolver
    {
        public Guid RequestID { get; set; }
        public string? Input { get; set; }
        public ActionRequest() 
        {
            RequestID = Guid.NewGuid();

        }
    }
}
