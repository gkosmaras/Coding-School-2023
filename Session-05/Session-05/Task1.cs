using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Input;

namespace Session_I
{
    public class StringReversal
    {
        public string Answer()
        {
            Inputer temp = new Inputer();
            char[] array = (temp.Answer1()).ToCharArray();
            StringBuilder tempSolved = new StringBuilder();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                tempSolved.Append(array[i]);
            }
            return tempSolved.ToString();
        }
    }
}
