using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input
{
    public class Inputer
    {
        public string Answer1()
        {
            Console.WriteLine("Please enter an input:");
            string temp = Console.ReadLine();
            return temp;
        }
        public int Answer2()
        {
            repeat:
                Console.WriteLine("Please enter an integer:");
                string temp = Console.ReadLine();
                int value;
                bool valid = int.TryParse(temp, out value);
                if (valid)
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("This is not a valid number.");
                    goto repeat;
                }
        }
        public string Answer3()
        {
            repeat:
                Console.WriteLine("Type s for sum or p for product:");
                string oper = Console.ReadLine();
                oper = oper.ToUpperInvariant();
                if (oper is "S" or "P")
                {
                return oper;
                }
                else
                {
                    Console.WriteLine("This is not a valid value.");
                    goto repeat;
                }
        }
    }
}


