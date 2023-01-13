using Session_I;
using Session_II;
using Session_III;
using Session_IV;
using Session_V;
using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] strings)
    {
        StringReversal temp = new StringReversal();
        SumProd temp1 = new SumProd();
        PrimeFinder temp2 = new PrimeFinder();
        Arrays temp3 = new Arrays();
        Organiser temp4 = new Organiser();
        Console.WriteLine(temp.Answer() + Environment.NewLine);
        Console.WriteLine(temp1.Answer() + Environment.NewLine);
        temp2.Answer();
        Console.WriteLine(Environment.NewLine);
        temp3.Answer();
        Console.WriteLine(Environment.NewLine);
        temp4.Answer();
        Console.ReadLine();
    }
}