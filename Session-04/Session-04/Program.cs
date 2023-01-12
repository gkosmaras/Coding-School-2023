using Session_I;
using Session_II;
using Session_III;
using Session_IV;
using Session_V;
using Session_VI;
using Session_VII;

internal class Program
{
    private static void Main(string[] args)
    {
        HelloName temp1 = new HelloName();
        SumDiv temp2 = new SumDiv();
        Results temp3 = new Results();
        AgeGender temp4 = new AgeGender();
        TimeConverter temp5 = new TimeConverter();
        TimeConverter2 temp6 = new TimeConverter2();
        TemperatureConverter temp7 = new TemperatureConverter();
        Console.WriteLine(temp1.Answer());
        Console.WriteLine(temp2.Answer());
        Console.WriteLine(temp3.Answer());
        Console.WriteLine(temp4.Answer());
        Console.WriteLine(temp5.Answer());
        Console.WriteLine(temp6.Answer());
        Console.WriteLine(temp7.Answer());
        Console.ReadLine();
    }
}