using System;

namespace task_DEV_5
{
    public static class StringHandler
    {
        public static int CountDifferentSymbolsMaxLength(this string inputString)
        {
            if(String.IsNullOrEmpty(inputString))
            {
                return 0;
            }    
            int count = 1, maxCount = 1;
            for (int i = 0; i < inputString.Length - 1; i++)
            {
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
        public static int CountSameLettersMaxLength(this string inputString)
        {
            if (CountLetters(inputString) == 0)
            {
                return 0;
            }
            int count = 1, maxCount = 1;
            for (int i = 0; i < inputString.Length - 1; i++)
            {
                char current = inputString[i];
                char next = inputString[i + 1];
                if ((current == next) && Char.IsLetter(current))
                {
                    count++;
                }
                else
                {
                    count = 1;
                    continue;
                }
                if (maxCount < count)
                {
                    maxCount = count;
                }
            }
            return maxCount;
        }
        public static int CountSameNumbersMaxLength(this string inputString)
        {
            if (CountNumbers(inputString) == 0)
            {
                return 0;
            }
            int count = 1, maxCount = 1;
            for (int i = 0; i < inputString.Length - 1; i++)
            {
                char current = inputString[i];
                char next = inputString[i + 1];
                if ((current == next) && Char.IsDigit(current))
                {
                    count++;
                }
                else
                {
                    count = 1;
                    continue;
                }
                if (maxCount < count)
                {
                    maxCount = count;
                }
            }
            return maxCount;
        }
        private static int CountLetters(this string inputString)
        {
            if (String.IsNullOrEmpty(inputString))
            {
                return 0;
            }
            int amountLetters = 0;
            foreach (char symbol in inputString)
            {
                if (Char.IsLetter(symbol))
                {
                    amountLetters++;
                }
            }
            return amountLetters;
        }
        private static int CountNumbers(this string inputString)
        {
            if (String.IsNullOrEmpty(inputString))
            {
                return 0;
            }
            int amountNumbers = 0;
            foreach(char symbol in inputString)
            {
                if(Char.IsNumber(symbol))
                {
                    amountNumbers++;
                }
            }
            return amountNumbers;
        }
    }
}


