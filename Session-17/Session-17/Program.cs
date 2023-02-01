using Session_17;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        //string question1 = "Πως μπορούμε να κάνουμε ένα Request σε ένα εξωτερικό API χωρίς να γνωρίζει ολόκληρο το url μας?";


        //question4 = "Μπορώ να έχω μια εφαρμογή που κάνει μόνο GET requests?";
        //question5 = "Μπορώ να έχω μια εφαρμογή που κάνει μόνο POST requests?";


        //question8 = "Μπορώ να κάνω Login με GET request?";


        Questions qList = new Questions();
        Answers aList = new Answers();
        for (int i = 0; i < qList.Headers().Count; i++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine((i+1).ToString() + ") " + qList.Headers()[i] 
                + Environment.NewLine, 
                Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(aList.Headers()[i] 
                + Environment.NewLine, 
                Console.ForegroundColor);
        }
        Console.ReadLine();
    }
}
