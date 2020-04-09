using System;
using System.Collections.Generic;
using System.Text;

namespace task_DEV_2._1
{
    class ConsoleCommandsProcessor
    {
        const string COUNT_ALL_COMMAND_STRING = "count all",
                     COUNT_TYPES_COMMAND_STRING = "count types",
                     AVERAGE_PRICE_COMMAND_STRING = "average price",
                     AVERAGE_PRICE_TYPE_COMMAND_STRING = "average price type",
                     LOAD_FILE_COMMAND_STRING = "load file",
                     NEW_FILE_COMMAND_STRING = "new file",
                     ADD_CAR_COMMAND_STRING = "add",
                     EXIT_COMMAND_STRING = "exit",
                     CAR_BRAND_ENTER_PROMPT_STRING = "Enter car brand",
                     CAR_MODEL_ENTER_PROMPT_STRING = "Enter car model",
                     CAR_PRICE_ENTER_PROMPT_STRING = "Enter car price",
                     CAR_Amount_ENTER_PROMPT_STRING = "Enter car amount",
                     INCORRECT_COMMAND_ERROR_MESSAGE = "Incorrect command";
        public ConsoleCommandsProcessor()
        {
            DataBase.GetInstance().TaskDone += DatabaseTaskDone; 
        }
        /// <summary>
        /// Gets command and arguments from console.
        /// </summary>
        /// <returns>Corresponding ICommand</returns>
        public ICommand GetICommandFromConsole()
        {
            Console.WriteLine(string.Format("Avaliable commands : {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}",
                COUNT_ALL_COMMAND_STRING, COUNT_TYPES_COMMAND_STRING, AVERAGE_PRICE_COMMAND_STRING, AVERAGE_PRICE_TYPE_COMMAND_STRING,
                LOAD_FILE_COMMAND_STRING, NEW_FILE_COMMAND_STRING, ADD_CAR_COMMAND_STRING, EXIT_COMMAND_STRING));
            string command = Console.ReadLine();
            switch (command)
            {
                case COUNT_ALL_COMMAND_STRING:
                    {
                        return new CountAllCommand();
                    }
                case AVERAGE_PRICE_COMMAND_STRING:
                    {
                        return new AveragePriceCommand();
                    }
                case COUNT_TYPES_COMMAND_STRING:
                    {
                        return new CountTypesCommand();
                    }
                case AVERAGE_PRICE_TYPE_COMMAND_STRING:
                    {
                        Console.WriteLine(CAR_BRAND_ENTER_PROMPT_STRING);
                        return new AveragePriceByTypeCommand(Console.ReadLine());
                    }
                case LOAD_FILE_COMMAND_STRING:
                    {
                        return new LoadFileCommand();
                    }
                case NEW_FILE_COMMAND_STRING:
                    {
                        return new NewFileCommand();
                    }
                case ADD_CAR_COMMAND_STRING:
                    {
                        return new AddCarCommand(GetCarFromConsole());
                    }
                case EXIT_COMMAND_STRING:
                    {
                        return new ExitCommand();
                    }
                default:
                    {
                        throw new ArgumentException(INCORRECT_COMMAND_ERROR_MESSAGE);
                    }
            }
        }
        /// <summary>
        /// Asks for user input for Car creation.
        /// </summary>
        /// <returns>New car </returns>
        public Car GetCarFromConsole()
        {
            Console.WriteLine(CAR_BRAND_ENTER_PROMPT_STRING);
            string brand = Console.ReadLine();
            Console.WriteLine(CAR_MODEL_ENTER_PROMPT_STRING);
            string model = Console.ReadLine();
            Console.WriteLine(CAR_PRICE_ENTER_PROMPT_STRING);
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine(CAR_Amount_ENTER_PROMPT_STRING);
            int amount = int.Parse(Console.ReadLine());
            return new Car(brand, model, amount, price);
        }
        private void DatabaseTaskDone(object sender, TaskDoneEventArgs e)
        {
            Console.WriteLine(string.Format("{0} - {1}", e.DataTitle, e.Data));
        }
    }
}
