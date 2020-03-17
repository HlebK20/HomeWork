using System;

namespace task_DEV_3
{
    class Chassis
    {
        int _numberOfWheels;
        string _serialNumber;
        double _permissibleLoad;

        public Chassis(int numberOfWheels, string serialNumber, double permissibleLoad)
        {
            NumberOfWheels = numberOfWheels;
            SerialNumber = serialNumber;
            PermissibleLoad = permissibleLoad;
        }
        public int NumberOfWheels
        {
            get { return _numberOfWheels; }
            set
            {
                CheckNull(value);
                _numberOfWheels = value;
            }
        }
        public string SerialNumber
        {
            get { return _serialNumber; }
            set
            {
                CheckNull(value);
                if (value == string.Empty)
                {
                    throw new FormatException();
                }
                _serialNumber = value;
            }
        }

        public double PermissibleLoad
        {
            get { return _permissibleLoad; }
            set
            {
                CheckNull(value);
                _permissibleLoad = value;
            }
        }
        private void CheckNull(object value)
        {
            if (value is null)
                throw new ArgumentNullException();
        }
    }
}
