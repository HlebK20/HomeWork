using System;
using System.Collections.Generic;
using System.Text;

namespace Convertor
{
    public class Convertor
    {
        const double fahrenheitCoefficient = 5.0 / 9;
        const double feetCoefficient = 3.281;
        public static double ConvertToCelsius(double fahrenheit)
        {
            return ((fahrenheit - 32) * fahrenheitCoefficient);
        }
        public static double ConvertToFahrenheit(double celsius)
        {
            return (celsius /fahrenheitCoefficient + 32);
        }
        public static double ConvertToFeets(double metres)
        {
            return metres * feetCoefficient;
        }
        public static double ConvertToMetres(double feets)
        {
            return feets / feetCoefficient;
        }

    }
}
