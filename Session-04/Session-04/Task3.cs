namespace Session_III
{
    public class Results
    {
        public string Answer()
        {
            short resultA = -1 + (5 * 6);
            short resultB = 38 + 5 % 7;
            short resultC = 14 + (-3 * 6) / 7;
            short resultD = (short)(2 + (13 / 6) * 6 + Math.Sqrt(7));
            short resultE = (short)(Math.Pow(6, 4) + Math.Pow(5, 7) / (9 % 4));
            string result = "The results of the operations are " + resultA +
                ", " + resultB + ", " + resultC + ", " + resultD + " and " + resultE + ".";
            return result;
        }
    }
}