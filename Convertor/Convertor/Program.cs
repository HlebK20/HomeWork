using System;

namespace Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(CmdHandler.Execute(args[0],args[1]));
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
