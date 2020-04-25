using System;

namespace Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(CmdConvertorHandler.Execute(args[0],args[1]));
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
