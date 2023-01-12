namespace Session_II
{
    public class SumDiv
    {
        public string Answer()
        {
            short numberA = 346;
            short numberB = 89;
            short sum = (short)(numberA + numberB);
            short div = (short)(numberA / numberB);
            short remainder = (short)(numberA % numberB);
            string result = "The sum of " + numberA + " and " + numberB +
                " is " + sum + " and their division is " + div + " with a remainder of " + remainder + ".";
            return result;
        }
    }
}