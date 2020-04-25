using System;
using System.Collections.Generic;

namespace Convertor
{
    public class CmdConvertorHandler
    {
        static readonly Dictionary<string, Method> CommandsAndLinks = new Dictionary<string, Method>();
        delegate double Method(double argument);
        static void FillDictionary()
        {
            CommandsAndLinks.Add("CF", Convertor.ConvertToFahrenheit);
            CommandsAndLinks.Add("FC", Convertor.ConvertToCelsius);
            CommandsAndLinks.Add("MFt", Convertor.ConvertToFeets);
            CommandsAndLinks.Add("FtM", Convertor.ConvertToMetres);
        }
        static void CheckStringsAreValid(string arg1, string arg2)
        {
            if (!double.TryParse(arg1, out double d))
            {
                throw new Exception("Can't convert first argument into number");
            }
            if(!CommandsAndLinks.ContainsKey(arg2))
            {
                throw new Exception("Incorrect command in second argument");
            }
        }
        public static double Execute(string arg1, string arg2)
        {
            if (CommandsAndLinks.Count == 0)
            {
                FillDictionary();
            }
            CheckStringsAreValid(arg1, arg2);
            double valueToConvert = Convert.ToDouble(arg1);

            CommandsAndLinks.TryGetValue(arg2, out Method associatedConvertor);
            return associatedConvertor.Invoke(valueToConvert);
        }
    }
}
