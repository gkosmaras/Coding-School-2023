namespace Session_04
{
    internal class Session_04
    {
        private static void Main(string[] args)
        {
            // Excercise 1
            string hello = "Hello";
            string name = "Giorgos";
            Console.WriteLine(hello + " " + name);

            // Excercise 2
            short numberA = 346;
            short numberB = 89;
            short sum = (short)(numberA + numberB);
            short div = (short)(numberA / numberB);
            short remainder = (short)(numberA % numberB);
            string result = "The sum of " + numberA + " and " + numberB +
                " is " + sum + " and their division is " + div + " with a remainder of " + remainder + ".";
            Console.WriteLine(result);

            // Excercise 3
            short resultA = -1 + (5 * 6);
            short resultB = 38 + 5 % 7;
            short resultC = 14 + (-3 * 6) / 7;
            short resultD = (short)(2 + (13 / 6) * 6 + Math.Sqrt(7));
            short resultE = (short)(Math.Pow(6, 4) + Math.Pow(5, 7) / (9 % 4));
            result = "The results of the operations are " + resultA +
                ", " + resultB + ", " + resultC + ", " + resultD + " and " + resultE + ".";
            Console.WriteLine(result);

            // Excercise 4
            int age = 43;
            string gender = " male ";
            result = "You are " + gender + "and you look younger than " + age + ".";
            Console.WriteLine(result);

            // Excercise 5
            int seconds = 45678;
            short minutes = (short)(seconds / 60);
            short hours = (short)(minutes / 60);
            short days = (short)(hours / 24);
            short years = (short)(days / 365);
            result = seconds + " seconds are " + minutes + " minutes, " +
                hours + " hours, " + days + " days and " + years + " years.";
            Console.WriteLine(result);

            // Excercise 6
            TimeSpan interval = new TimeSpan(0, 0, 45678);
            seconds = (int)interval.TotalSeconds;
            minutes = (short)interval.TotalMinutes;
            hours = (short)interval.TotalHours;
            days = (short)interval.TotalDays;
            years = (short)(days / 365);
            result = seconds + " seconds are " + minutes + " minutes, " +
                hours + " hours, " + days + " days and " + years + " years.";
            Console.WriteLine(result);

            // Excercise 7
            short celsius = 12;
            short fahr = (short)((celsius * 9) / 5 + 32);
            short kelvin = (short)(celsius + 273);
            Console.WriteLine(celsius + " degress Celsius are " + fahr +
                " degrees Fahrenheit and " + kelvin + " degrees Kelvin.");
            Console.ReadLine();
        }
    }
}