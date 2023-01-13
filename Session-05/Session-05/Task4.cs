using System;

namespace Session_IV
{
    public class Arrays
    {
        public void Answer()
        {
            int[] array1 = {2, 4, 9, 12};
            int[] array2 = { 1, 3, 7, 10 };
            int[,] newArray = new int[4, 4];
            for (int i =0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    newArray[i, j] = array1[i] * array2[j];
                }
            }
            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int j = 0; j < newArray.GetLength(1); j++)
                {
                    Console.Write(newArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
