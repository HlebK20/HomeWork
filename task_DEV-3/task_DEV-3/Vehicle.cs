using System;

namespace task_DEV_3
{
    abstract public class Vehicle
    {
        Engine _engine;
        Transmission _transmission;
        Chassis _chassis;
        string _vehicleType;
        public Vehicle(Engine engine, Transmission transmission, Chassis chassis, string vehicleType)
        {
            Engine = engine;
            Transmission = transmission;
            Chassis = chassis;
            _vehicleType = (string)CheckValid(vehicleType);
        }
        protected Chassis Chassis
        {
            get { return _chassis; } 
            set
            {
                CheckValid(value);
                _chassis = value;
            }
        }
        protected Transmission Transmission
        {
            get { return _transmission; }
            set
            {
                CheckValid(value);
                _transmission = value;
            }
        }
        protected Engine Engine
        {
            get { return _engine; }
            set
            {
                CheckValid(value);
                _engine = value;
            }
        }
        protected string VehicleType
        {
            get => _vehicleType;
            set
            {
                CheckValid(value);
                _vehicleType = value;
            }
        }
        virtual public void GetInfo()
        {
            Console.WriteLine("Vehicle type is " + _vehicleType);
            _engine.GetInfo();
            _transmission.GetInfo();
            _chassis.GetInfo();
        }
        protected object CheckValid(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Argument is null");
            }
            if (value is string)
            {
                if ((string)value == string.Empty)
                {
                    throw new FormatException("String is empty");
                }
                CheckStringSymbols((string)value);
            }
            return value;
        }
        private void CheckStringSymbols(string str)
        {
            foreach (char symbol in str)
            {
                if (!Char.IsLetterOrDigit(symbol))
                {
                    throw new FormatException("String can contain only letters and numbers");
                }
            }
        }
    }
}
