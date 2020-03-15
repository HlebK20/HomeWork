using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_1
{
    public class StringDif
    {
        public static int CountDifferentSymbols(string string_from_cmd)
        {
            if (string_from_cmd.Length == 0)
                return 0;
            int count = 1;
            int maxcount = count;
            for (int i = 1; i < string_from_cmd.Length; i++)
            {

                if (string_from_cmd[i] == string_from_cmd[i - 1])
                {
                    count = 1;
                }
                if (string_from_cmd[i] != string_from_cmd[i - 1])
                {
                    count++;
                }
                if (maxcount < count)
                {
                    maxcount = count;
                }
            }
            return maxcount;
        }
    }
}
