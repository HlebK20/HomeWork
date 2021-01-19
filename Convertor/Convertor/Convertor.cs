namespace Convertor
{
    public class Convertor
    {
        const double FAHRENHEIT_COEFFICIENT = 5.0 / 9;
        const double FEET_COEFFICIENT = 3.281;
        public static double ConvertToCelsius(double fahrenheit)
        {
            return ((fahrenheit - 32) * FAHRENHEIT_COEFFICIENT);
        }
        public static double ConvertToFahrenheit(double celsius)
        {
            return (celsius /FAHRENHEIT_COEFFICIENT + 32);
        }
        public static double ConvertToFeets(double metres)
        {
            return metres * FEET_COEFFICIENT;
        }
        public static double ConvertToMetres(double feets)
        {
            return feets / FEET_COEFFICIENT;
        }

    }
}
