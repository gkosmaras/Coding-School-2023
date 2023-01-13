using System;
using Input;

namespace Session_III
{
    public class PrimeFinder
    {
        public void Answer()
        {
            Inputer temp = new Inputer();
            int number = temp.Answer2();
            var array = Array.Empty<int>();
            for (int i = 3; i <= number; i++)
            {
                bool cond = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        cond = false;
                    }
                }
                if (cond)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
 }