using System;

namespace task_DEV_3
{
    public class Chassis
    {
        int _numberOfWheels;
        string _serialNumber;
        double _permissibleLoad;
        const int _minNumberOfWheels = 1;
        const double _minPermissibleLoad = 1;

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
                CheckValid(value);
                if(value<_minNumberOfWheels)
                {
                    throw new ArgumentOutOfRangeException("Number of wheels can't be lower than " + _minNumberOfWheels);
                }
                _numberOfWheels = value;
            }
        }
        public string SerialNumber
        {
            get { return _serialNumber; }
            set
            {
                CheckValid(value);
                _serialNumber = value;
            }
        }
        public double PermissibleLoad
        {
            get { return _permissibleLoad; }
            set
            {
                CheckValid(value);
                if(value<_minPermissibleLoad)
                {
                    throw new ArgumentOutOfRangeException("Permissible load can't be lower than "+_minPermissibleLoad);
                }
                _permissibleLoad = value;
            }
        }
        public void GetInfo()
        {
            Console.WriteLine("\tChassis:");
            Console.WriteLine("\t\tNumber of wheels is    " + _numberOfWheels);
            Console.WriteLine("\t\tSerial number is       " + _serialNumber);
            Console.WriteLine("\t\tPermissible load is    " + _permissibleLoad+"\n");
        }
        private void CheckValid(object value)
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