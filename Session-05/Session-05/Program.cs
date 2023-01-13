using Session_I;
using Session_II;
//using Session_III;
using Session_IV;
using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] strings)
    {
        StringReversal temp = new StringReversal();
        SumProd temp1 = new SumProd();
        //PrimeFinder temp2 = new PrimeFinder();
        Arrays temp3 = new Arrays();
        Console.WriteLine(temp.Answer());
        Console.WriteLine(temp1.Answer());
        temp3.Answer();
        Console.ReadLine();
    }
}