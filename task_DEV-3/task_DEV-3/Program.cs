using System;

namespace task_DEV_3
{
    class Program
    {
        static void Main()
        {
            try
            {
                Engine engine = new Engine(2.5, 2.9, "Some type of engine", "25OHC");
                Transmission transmission = new Transmission("Some type of transmission", "IDK inc", 6);
                Chassis chassis = new Chassis(4, "123CDF", 1270);
                Car car = new Car(4, engine, transmission, chassis);
                car.GetInfo();
            }
            catch(Exception Exc)
            {
                Console.WriteLine(Exc.Message);
            }
        }
    }

}
