using System;

namespace task_DEV_2
{
    class EntryPoint
    {
        static void Main(string []args)
        {
            try
            {
                int number = Number.ConvertToInt(args[0]);
                int systemBase = Number.ConvertToInt(args[1]);

                Number number1 = new Number(number);
                Console.WriteLine("Converted number is " + number1.ConvertToAnotherBase(systemBase));
            }
            catch (Exception Exc)
            {
                Console.WriteLine(Exc.Message);
            }
        }
    }
}