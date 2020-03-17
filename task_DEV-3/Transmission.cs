using System;

namespace task_DEV_3
{
    public class Transmission
    {
        string _typeTransmission;
        string _vendor;
        int _numberOfGears;
        public Transmission(string typeTransmission, string vendor, int numberOfGears)
        {
            TypeTransmission = typeTransmission;
            Vendor = vendor;
            NumberOfGears = numberOfGears;
        }
        public string Vendor
        {
            get { return _vendor; }
            set
            {
                CheckNullOrEmpty(value);
                _vendor = value;
            }
        }
        public string TypeTransmission
        {
            get { return _typeTransmission; }
            set
            {
                CheckNullOrEmpty(value);
                _typeTransmission = value;
            }
        }

        public int NumberOfGears
        {
            get { return _numberOfGears; }
            set
            {
                CheckNullOrEmpty(value);
                _numberOfGears = value;
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
