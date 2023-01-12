namespace Session_V
{
    public class TimeConverter
    {
        public string Answer()
        {
            int seconds = 45678;
            short minutes = (short)(seconds / 60);
            short hours = (short)(minutes / 60);
            short days = (short)(hours / 24);
            short years = (short)(days / 365);
            string result = seconds + " seconds are " + minutes + " minutes, " +
                hours + " hours, " + days + " days and " + years + " years.";
            return result;
        }
    }
}