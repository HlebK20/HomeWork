using System;

namespace DEV_1
{
    public class DifferentSymbolMaxLengthCounter
    {
        /// <summary>
        /// Finds the maximal length of a series of different symbols
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns>Maximal length of a series of different symbols</returns>
        public static int CountDifferentSymbols(string inputString)
        {
            //Check if string is null
            if (inputString == null)
            {
                throw new ArgumentNullException();
            }
            //Check if string is empty
            if (inputString.Length == 0)
            {
                return 0;
            }
            int count = 1, maxCount = 1;
            for (int i = 0; i < inputString.Length-1; i++)
            {
                //Comparing current and next symbol
                if (inputString[i] == inputString[i + 1])
                {
                    count = 1;
                    continue;
                }
                else 
                {
                    count++;
                }
                if (maxCount < count)
                {
                    maxCount = count;
                }
            }
            return maxCount;
        }
    }
}
