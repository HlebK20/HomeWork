using System;

namespace DEV_1
{
    class Program
    {
       static void Main(string []args)
        {
            try
            {
               string str = args[0];
               Console.WriteLine("DifferentSymbolMaxLengthCounter.CountDifferentSymbols(str)");
            }
            catch (Exception Exc)
            {
                Console.WriteLine(Exc.Message);
            }
    }
}
