using System;

namespace task_DEV_3
{
    class Engine
    {
        double _power;
        double _Volume;
        string _typeOfEngine;
        string _serialNumber;
        public Engine(double power, double volume, string typeOfEngine, string serialNumber)
        {
            Power = power;
            Volume = volume;
            TypeOfEngine = typeOfEngine;
            SerialNumber = serialNumber;
        }
        public double Volume
        {
            get { return _Volume; }
            set
            {
                CheckNull(value);
                _Volume = value;
            }
        }
        public string TypeOfEngine
        {
            get { return _typeOfEngine; }
            set
            {
                CheckNull(value);
                _typeOfEngine = value;
            }
        }
        public double Power
        {
            get { return _power; }
            set
            {
                CheckNull(value);
                _power = value;
            }
        }
        public string SerialNumber
        {
            get { return _serialNumber; }
            set
            {
                CheckNull(value);
                _serialNumber = value;
            }
        }
        private void CheckNull(object value)
        {
            if (value is null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
