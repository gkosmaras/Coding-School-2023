using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public enum ActionEnum
    {
        Convert,
        Uppercase,
        Reverse
    }
    public class ActionResolver
    {
        public MessageLogger Logger { get; set; }
        public ActionResolver()
        {

        }
        public ActionResponse Execute(ActionRequest request)
        {
            return null;
        }
    }
}
