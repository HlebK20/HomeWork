using System;

namespace task_DEV_3
{
    abstract public class Vehicle
    {
        Engine _engine;
        Transmission _transmission;
        Chassis _chassis;
        string _vehicleType;
        protected Vehicle(Engine engine, Transmission transmission, Chassis chassis, string vehicleType)
        {
            _engine = engine;
            _transmission = transmission;
            _chassis = chassis;
            _vehicleType = CheckForNullAndEmpty(vehicleType);
        }
        protected void GetInfo()
        {
            Console.WriteLine("Vehicle type is " + _vehicleType);
            _engine.GetInfo();
            _transmission.GetInfo();
            _chassis.GetInfo();
        }
        protected string CheckForNullAndEmpty(string input)
        {
            if (input is null)
            {
                throw new ArgumentNullException("String is null");
            }
            if (input == string.Empty)
            {
                throw new FormatException("String is empty");
            }
            return input;
        }
    }
}
