using Session_17;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Questions qList = new Questions();
        Answers aList = new Answers();
        int width = Console.WindowWidth;
        for (int i = 0; i < qList.Headers().Count; i++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string temp = (i + 1).ToString() + ") " + qList.Headers()[i];
            Console.WriteLine(temp
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
