using System;

namespace task_DEV_2
{
    /// <summary>
    /// This class converts number from decimal to another base in range from 2 to 20
    /// </summary>
    public class Number
    {
        int _number10;  //Decimal number
        int _systemBase;//System base of result. From 2 to 20
        public Number(int number, int systemBase)
        {
            _number10 = number;
            _systemBase = systemBase;
        }
        public Number(string str, int systemBase)
        {
            //If we don't check it, it will work properly without any exception due to Convert.ToInt32
            CheckStringIsCorrect(str);
            _number10 = Convert.ToInt32(str);
            _systemBase = systemBase;
        }
        /// <summary>
        /// This method converts from decimal system to _systemBase 
        /// </summary>
        /// <returns></returns>
        public string ConvertToAnotherBase()
        {
            CheckObjectIsNull();
            int number, systemBase;
            //Check if the convert is necessarily
            if (_systemBase == 10)
            {
                return _number10.ToString();
            }
            //Set systemBase if _systembase is in range
            if (_systemBase > 20 || _systemBase < 2)
            {
                throw new ArgumentException();
            }
            else
            {
                systemBase = _systemBase;
            }
            //Set number, make it positive if it's negative
            if (_number10 < 0)
            {
                number = -_number10;
            }
            else
            {
                number = _number10;
            }
            int intFromDivision = number;
            string convertedNumber = "";
            int i = 0;
            if (number < systemBase)
            {
                convertedNumber+= ConvertIntToSymbol(number);
            }

            //Counting maximal digit in result
            while (intFromDivision >= systemBase)
            {
                intFromDivision = number / (int)Math.Pow(systemBase, i);
                i++;
            }

            //Making conversion from largest digit
            while (i != 0)
            {
                i--;
                intFromDivision = number / (int)Math.Pow(systemBase, i);
                number -= intFromDivision * (int)Math.Pow(systemBase, i);
                convertedNumber += ConvertIntToSymbol(intFromDivision);
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
            string notDigitalValues = "ABCDEFGIJI";
            if (number >= 10)
            {
                return Convert.ToString(notDigitalValues[number - 10]);
            }
            return Convert.ToString(number);
        }
        /// <summary>
        /// This method checks if our object is null
        /// </summary>
        private void CheckObjectIsNull()
        {
            if (this is null)
            {
                throw new NullReferenceException();
            }
        }
        private void CheckStringIsCorrect(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException();
            }
            if (str == string.Empty)
            {
                throw new FormatException();
            }
            for(int i = 0; i < str.Length; i++)
            {
                if (!Char.IsNumber(str, i) && str[i] != '-')
                {
                    throw new FormatException();
                }
            }
        }
    }
}