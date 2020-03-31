using System;

namespace task_DEV_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = args[0];
                Console.WriteLine(str.CountDifferentSymbolsMaxLength());
                Console.WriteLine(str.CountSameLettersMaxLength());
                Console.WriteLine(str.CountSameNumbersMaxLength());
            }
            catch (Exception Exc)
            {
                Console.WriteLine(Exc.Message);
            }
        }
    }
}
