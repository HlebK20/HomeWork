using System;

namespace DEV_1
{
    class Program
    {
        static void Main()
        {
            string string_from_cmd;
            string_from_cmd = Console.ReadLine();

            int count = 1;
            int maxcount = count;

            for (int i = 1; i < string_from_cmd.Length; i++)
            {
                if (string_from_cmd[i] == string_from_cmd[i - 1])
                {
                    count++;
                }
                if (maxcount < count)
                {
                    maxcount = count;
                }
                if (string_from_cmd[i] != string_from_cmd[i - 1])
                {
                    count = 1;
                }
            }
            Console.WriteLine(maxcount);
        }
    }
}
