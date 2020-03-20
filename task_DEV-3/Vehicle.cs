using System;

namespace task_DEV_3
{
    abstract public class Vehicle
    {
        Engine _engine;
        Transmission _transmission;
        Chassis _chassis;
        string _vehicleType;
        protected void GetInfo()
        {
            Console.WriteLine("Engine is " + _engine);
            Console.WriteLine("Transmission is " + _transmission);
            Console.WriteLine("Chassis is " + _chassis);
            Console.WriteLine("Vehicle type is " + _vehicleType);
        }
        protected Vehicle(Engine engine, Transmission transmission, Chassis chassis, string vehicleType)
        {
            _engine = engine;
            _transmission = transmission;
            _chassis = chassis;
            _vehicleType = CheckForNullAndEmpty(vehicleType);
        }
        protected string CheckForNullAndEmpty(string input)
        {
            if (input == string.Empty)
            {
                throw new FormatException("String is empty");
            }
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException("String is null");
            }
            return input;
        }
    }
}
