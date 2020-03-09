using System;

namespace task_DEV_3
{
    class Transmission
    {
        string _TypeTrn;
        string _Vendor;
        int _GearNum;
        public Transmission(string TypeTrn, string Vendor, int GearNum)
        {
            _TypeTrn = TypeTrn;
            _Vendor = Vendor;
            _GearNum = GearNum;
        }
        public string Vendor
        {
            get { return _Vendor; }
            set
            {
                CheckNull(value);
                _Vendor = value;
            }
        }
        public string TypeTrn
        {
            get { return _TypeTrn; }
            set
            {
                CheckNull(value);
                _TypeTrn = value;
            }
        }

        public int GearNum
        {
            get { return _GearNum; }
            set
            {
                CheckNull(value);
                _GearNum = value;
            }
        }
        private void CheckNull(object value)
        {
            if (value == null)
                throw new ArgumentNullException();
        }
    }
}
