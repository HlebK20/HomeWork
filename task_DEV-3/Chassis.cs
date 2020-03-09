using System;

namespace task_DEV_3
{
    class Chassis
    {
        int _Wheels;
        string _SerialNum;
        double _Allowed;

        public Chassis(int wheels, string serialNum, double allowed)
        {
            Wheels = wheels;
            SerialNum = serialNum;
            Allowed = allowed;
        }
        public int Wheels
        {
            get { return _Wheels; }
            set
            {
                CheckNull(value);
                _Wheels = value;
            }
        }
        public string SerialNum
        {
            get { return _SerialNum; }
            set
            {
                CheckNull(value);
                _SerialNum = value;
            }
        }

        public double Allowed
        {
            get { return _Allowed; }
            set
            {
                CheckNull(value);
                _Allowed = value;
            }
        }
        private void CheckNull(object value)
        {
            if (value == null)
                throw new ArgumentNullException();
        }
    }
}
