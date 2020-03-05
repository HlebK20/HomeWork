using System;

namespace task_DEV_2
{
    class EntryPoint
    {
        static void Main()
        {
            Console.WriteLine(NumberSystemConverter(readInt(), readInt()));
        }

        static string NumberSystemConverter(int number, int systemBase)
        {
            int cel = number;
            string convertedNumber = "";
            int i = 0;
            while (cel >= systemBase)
            {
                cel = number / (int)Math.Pow(systemBase, i);
                i++;
            }
            while (number > systemBase)
            {
                i--;
                cel = number / (int)Math.Pow(systemBase, i);
                number -= cel * (int)Math.Pow(systemBase, i);
                convertedNumber += getSymbol(cel);
            }
            convertedNumber += getSymbol(number);
            return convertedNumber;
        }
        static int readInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        static string getSymbol(int number)
        {
            string notDigitalValues = "ABCDEFGIJI";
            if (number >= 10)
                return Convert.ToString(notDigitalValues[number - 10]);
            return Convert.ToString(number);
        }
    }
}