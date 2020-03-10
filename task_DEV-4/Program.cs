using System;

namespace task_DEV_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Point p1 = new Point(20, 20, 20);
                Point p2 = new Point(100, 100, 100);
                int speed = 0;
                int maxspeed = 1500;
            }
            catch (ArgumentException) 
            {
                Console.WriteLine("Incorrect input, must be more then 0 or equal");
            }

        }
    }
}
