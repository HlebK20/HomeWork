using System;

namespace task_DEV_3
{
    class Engine
    {
        double _Power;
        double _Volume;
        string _TypeEng;
        string _SerialNum;
        public Engine(double Power, double Volume, string TypeEng, string SerialNum)
        {
            _Power = Power;
            _Volume = Volume;
            _TypeEng = TypeEng;
            _SerialNum = SerialNum;
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
        public string TypeEng
        {
            get { return _TypeEng; }
            set
            {
                CheckNull(value);
                _TypeEng = value;
            }
        }
        public double Power
        {
            get { return _Power; }
            set
            {
                CheckNull(value);
                _Power = value;
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
        private void CheckNull(object value)
        {
            if (value == null)
                throw new ArgumentNullException();
        }
    }
}
