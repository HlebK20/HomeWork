using System;
using System.Collections.Generic;

namespace task_DEV_2._1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            try
            {
                var consoleCommandsProcessor = new ConsoleCommandsProcessor();
                var commandExecutor = new CommandExecutor();
                while (true)
                {
                    commandExecutor.SetCommand(consoleCommandsProcessor.GetICommandFromConsole());
                    commandExecutor.ExecuteCommand();
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

        }
    }
}