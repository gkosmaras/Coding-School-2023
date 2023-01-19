using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_X
{
    public class StringManipulator
    {
        public string Text { get; set; }
        public virtual string Manipulate()
        {
            return string.Empty;
        }
    }

    public class StringConvert : StringManipulator
    {
        public override string Manipulate()
        {
            // Do conversion

            return "1";
        }
    }
    public class StringReverse : StringManipulator
    {
        public override string Manipulate()
        {
            // Do manipulate
            return string.Empty;
        }
    }
    public class StringUpper : StringManipulator
    {
        public override string Manipulate()
        {
            // Do uppercase
            return "3";
        }
    }
}
