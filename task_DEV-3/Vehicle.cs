using System;

namespace task_DEV_3
{
    abstract public class Vehicle
    {
        Engine _engine;
        Transmission _transmission;
        Chassis _chassis;
        protected void GetInfo()
        {
            Console.WriteLine("Engine is " + _engine);
            Console.WriteLine("Transmission is " + _transmission);
            Console.WriteLine("Chassis is " + _chassis);
        }
        protected Vehicle(Engine engine, Transmission transmission, Chassis chassis)
        {
            _engine = engine;
            _transmission = transmission;
            _chassis = chassis;
        }
        protected void CheckForNullAndEmpty(string input)
        {
            if (input == string.Empty)
            {
                throw new FormatException();
            }
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException();
            }
        }
    }
}
