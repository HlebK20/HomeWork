using System;

namespace task_DEV_3
{
    public class Chassis
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
                CheckNullOrEmpty(value);
                _numberOfWheels = value;
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

        public double PermissibleLoad
        {
            get { return _permissibleLoad; }
            set
            {
                CheckNullOrEmpty(value);
                _permissibleLoad = value;
            }
        }
        private void CheckNullOrEmpty(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }
            if (value.GetType() == typeof(string) && (string)value == string.Empty)
            {
                throw new FormatException();
            }
        }
    }
}