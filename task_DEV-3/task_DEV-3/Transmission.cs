using System;

namespace task_DEV_3
{
    public class Transmission
    {
        string _transmissionType;
        string _vendor;
        int _numberOfGears;
        const int _minNumberOfGears = 2;
        public Transmission(string transmissionType, string vendor, int numberOfGears)
        {
            TransmissionType = transmissionType;
            Vendor = vendor;
            NumberOfGears = numberOfGears;
        }
        public string TransmissionType
        {
            get { return _transmissionType; }
            set
            {
                CheckValid(value);
                _transmissionType = value;
            }
        }
        public string Vendor
        {
            get { return _vendor; }
            set
            {
                CheckValid(value);
                _vendor = value;
            }
        }
        public int NumberOfGears
        {
            get { return _numberOfGears; }
            set
            {
                CheckValid(value);
                if(value<_minNumberOfGears)
                {
                    throw new ArgumentOutOfRangeException("Number of gears can't be lower than "+_minNumberOfGears);
                }
                _numberOfGears = value;
            }
        }
        public void GetInfo()
        {
            Console.WriteLine("\tTransmission");
            Console.WriteLine("\t\tTransmission type is   " + _transmissionType);
            Console.WriteLine("\t\tVendor is              " + _vendor);
            Console.WriteLine("\t\tNumber of gears is     " + _numberOfGears + "\n");
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
