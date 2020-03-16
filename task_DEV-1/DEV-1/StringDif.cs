using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_1
{
    public class StringDif
    {
        /// <summary>
        /// Finds the maximal length of a series of different symbols
        /// </summary>
        /// <param name="string_with_symbols"></param>
        /// <returns>Maximal length of a series of different symbols</returns>
        public static int CountDifferentSymbols(string string_with_symbols)
        {
            //Check if string is empty
            if (string_with_symbols.Length == 0)
                return 0;
            int count = 1;
            int maxcount = count;
            for (int i = 1; i < string_with_symbols.Length; i++)
            {
                //Comparing current and previos symbol
                if (string_with_symbols[i] == string_with_symbols[i - 1])
                {
                    count = 1;
                }
                if (string_with_symbols[i] != string_with_symbols[i - 1])
                {
                    count++;
                }
                if (maxcount < count)
                {
                    maxcount = count;
                }
            }
            return maxcount;
        }
    }
}
