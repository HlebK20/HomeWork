using System;

namespace task_DEV_3
{
    class Transmission
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
                CheckNull(value);
                _vendor = value;
            }
        }
        public string TypeTransmission
        {
            get { return _typeTransmission; }
            set
            {
                CheckNull(value);
                _typeTransmission = value;
            }
        }

        public int NumberOfGears
        {
            get { return _numberOfGears; }
            set
            {
                CheckNull(value);
                _numberOfGears = value;
            }
        }
        private void CheckNull(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
