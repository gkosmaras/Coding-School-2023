using System;
using Input;

namespace Session_II
{
    public class SumProd
    {
        public int Answer()
        {
            int sum = 0;
            Inputer temp = new Inputer();
            int number = temp.Answer2();
            string oper = temp.Answer3();
                if (oper == "S")
                {
                    sum = 0;
                    for (int i = 0; i <= number; i++)
                    {
                        sum += i;
                    }
                }
                else if (oper == "P")
                {
                    sum = 1;
                    for (int i = 1; i <= number; i++)
                    {
                        sum *= i;
                    }
                }
        return sum;
        }
    }
}