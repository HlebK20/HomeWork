using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Convertor
{
    public class CmdHandler
    {
        public static readonly List<string> AllowedConvertionsList = new List<string>();
        
        delegate double Method(double argument);
        static void FillCommandList()
        {
            AllowedConvertionsList.Add("CF");
            AllowedConvertionsList.Add("FC");
            AllowedConvertionsList.Add("FtM");
            AllowedConvertionsList.Add("MFt");
        }

        static void CheckStringsAreValid(string arg1, string arg2)
        {
            if (!double.TryParse(arg1, out double d))
            {
                throw new Exception("Can't convert first argument into number");
            }
            if(!AllowedConvertionsList.Contains(arg2))
            {
                throw new Exception("Uncorrect command in second argument");
            }
        }
        public static double Execute(string arg1, string arg2)
        {
            FillCommandList();
            CheckStringsAreValid(arg1, arg2);
            double valueToConvert = Convert.ToDouble(arg1);
            int caseSwitch = AllowedConvertionsList.IndexOf(arg2);
            switch (caseSwitch)
            {
                case 0:
                    return Convertor.ConvertToFahrenheit(valueToConvert);
                case 1:
                    return Convertor.ConvertToCelsius(valueToConvert);
                case 2:
                    return Convertor.ConvertToMetres(valueToConvert);
                case 3:
                    return Convertor.ConvertToFeets(valueToConvert);
            }
            return 0;
        }
    }
}
