using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Session_07
{
    public class ActionResponse
    {
        public Guid RequestIO { get; set; }
        public Guid ResponseID { get; set; }
        public string Output { get; set; }

        public ActionResponse()
        {
            ResponseID = Guid.NewGuid();
        }
    }    
}
