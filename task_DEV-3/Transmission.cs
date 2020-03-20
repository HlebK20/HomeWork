using System;

namespace task_DEV_3
{
    public class Transmission
    {
        string _transmissionType;
        string _vendor;
        int _numberOfGears;
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
                CheckNullOrEmpty(value);
                _transmissionType = value;
            }
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
