using System;

namespace task_DEV_2
{
    /// <summary>
    /// This class converts number from decimal to another base in range from 2 to 20
    /// </summary>
    public class Number
    {
        int _number10;                  //Decimal number
        int _currentSystemBase = 10;    //Current systembase. From 2 to 20
        const int systemBaseMin = 2;
        const int systemBaseMax = 20;
        static string _systemBaseError = "This system base is not allowed. Allowed system bases: from " + systemBaseMin + " to " + systemBaseMax;
        static string _formatError = "Wrong format. Only numbers and minus sign (at the start) allowed";
        #region Constructors
        public Number(int number, int systemBase)
        {
            _number10 = number;
            _currentSystemBase = systemBase;
        }
        public Number(string str, int systemBase)
        {
            //If we don't check it, it will work properly without any exception due to Convert.ToInt32
            _number10 = ConvertToInt(str);
            _currentSystemBase = systemBase;
        }
        public Number(int number)
        {
            _number10 = number;
        }
        public Number(string str)
        {
            //If we don't check it, it will work properly without any exception due to Convert.ToInt32
            _number10 = ConvertToInt(str);
        }
        #endregion Constructors
        /// <summary>
        /// This method converts from decimal system to _systemBase 
        /// </summary>
        /// <returns></returns>
        public string ConvertToAnotherBase(int systemBase)
        {
            //Check systemBase
            if (systemBase < systemBaseMin || systemBase > systemBaseMax)
            {
                throw new ArgumentException(_systemBaseError);
            }

            //Set number, make it positive if it's negative
            int number = Math.Abs(_number10);
            int divisionRemain;
            string convertedNumber = "";

            while(number!=0)
            {
                divisionRemain = number % systemBase;
                number /= systemBase;
                convertedNumber = ConvertIntToSymbol(divisionRemain) + convertedNumber;
            }

            //Adding minus for negative numbers
            if (_number10 < 0)
            {
                convertedNumber = convertedNumber.Insert(0, "-");
            }
            return convertedNumber;
        }

        /// <summary>
        /// Converting integer number to symbol
        /// </summary>
        /// <param name="number">Number to convert</param>
        /// <returns>String with converted symbol</returns>
        private string ConvertIntToSymbol(int number)
        {
            if (number >= 10)
            {
                return Convert.ToString((char)(65+(number-10)));
            }
            return Convert.ToString(number);
        }

        public static int ConvertToInt(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException();
            }
            if (str == string.Empty)
            {
                throw new FormatException(_formatError);
            }
            for(int i = 0; i < str.Length; i++)
            {
                //If character is not a number and is not a minus at the start of the string, throw an exception
                if (!Char.IsNumber(str, i) && (str[i] != '-' || i != 0))
                {
                    throw new FormatException(_formatError);
                }
            }
            return Convert.ToInt32(str);
        }
    }
}