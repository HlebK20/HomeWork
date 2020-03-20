using System;

namespace task_DEV_3
{
    public class Engine
    {
        double _power;
        double _volume;
        string _engineType;
        string _serialNumber;
        const double _minPower = 0;
        const double _minVolume = 0;
        public Engine(double power, double volume, string typeOfEngine, string serialNumber)
        {
            Power = power;
            Volume = volume;
            TypeOfEngine = typeOfEngine;
            SerialNumber = serialNumber;
        }
        public double Power
        {
            get { return _power; }
            set
            {
                CheckNullOrEmpty(value);
                if(value<_minPower)
                {
                    throw new ArgumentOutOfRangeException("Power can't be lower than " + _minPower);
                }
                _power = value;
            }
        }
        public double Volume
        {
            get { return _volume; }
            set
            {
                CheckNullOrEmpty(value);
                if (value < _minVolume)
                {
                    throw new ArgumentOutOfRangeException("Volume can't be lower than " + _minVolume);
                }
                _volume = value;
            }
        }
        public string TypeOfEngine
        {
            get { return _engineType; }
            set
            {
                CheckNullOrEmpty(value);
                _engineType = value;
            }
        }
        public string SerialNumber
        {
            get { return _serialNumber; }
            set
            {
                CheckNullOrEmpty(value);
                _serialNumber = value;
            }
        }
        public void GetInfo()
        {
            Console.WriteLine("\tEngine:");
            Console.WriteLine("\t\tPower is               " + _power);
            Console.WriteLine("\t\tVolume is              " + _volume);
            Console.WriteLine("\t\tEngine type is         " + _engineType);
            Console.WriteLine("\t\tSerial number is       " + _serialNumber + "\n");
        }
        private void CheckNullOrEmpty(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Argument is null");
            }
            if (value.GetType() == typeof(string) && (string)value == string.Empty)
            {
                throw new FormatException("String is empty");
            }
        }
    }
}
