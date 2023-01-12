namespace Session_VII
{
    public class TemperatureConverter
    {
        public string Answer()
        {
            short celsius = 12;
            short fahr = (short)((celsius * 9) / 5 + 32);
            short kelvin = (short)(celsius + 273);
            string result = celsius + " degress Celsius are " + fahr +
                " degrees Fahrenheit or " + kelvin + " degrees Kelvin.";
            return result;
        }
    }
} 