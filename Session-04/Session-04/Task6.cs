namespace Session_VI
{
    public class TimeConverter2
    {
        public string Answer()
        {
            TimeSpan interval = new TimeSpan(0, 0, 45678);
            int seconds = (int)interval.TotalSeconds;
            short minutes = (short)interval.TotalMinutes;
            short hours = (short)interval.TotalHours;
            short days = (short)interval.TotalDays;
            short years = (short)(days / 365);
            string result = seconds + " seconds are " + minutes + " minutes, " +
                hours + " hours, " + days + " days and " + years + " years.";
            return result;
        }
    }
}