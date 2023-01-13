using System;

namespace Session_V
{
    public class Organiser
    {
        public void Answer()
        {
            int[] array = { 0, 2, 1, 20, -31, 50, -4, 17, 89, 100 };
            Array.Sort(array);
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}
