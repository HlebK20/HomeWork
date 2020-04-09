using System;
using System.Collections.Generic;
using System.Text;

namespace task_DEV_2._1
{
    class Car
    {
        string _tradeMark;
        string _model;
        int _amount;
        int _cost;
        const int MIN_AMOUNT = 1;
        const int MIN_COST = 1;
        public Car(string tradeMark, string model, int amount, int cost)
        {
            _tradeMark = tradeMark;
            _model = model;
            _amount = amount;
            _cost = cost;
        }
        public string TradeMark
        {
            get { return _tradeMark; }
            set
            {
                CheckString(value);
                _tradeMark = value;
            }
        }
        public string Model
        {
            get { return _model; }
            set
            {
                CheckString(value);
                _model = value;
            }
        }
        public int Amount
        {
            get { return _amount; }
            set
            {
                if (value < MIN_AMOUNT)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Amount = value;
            }
        }
        public int Cost
        {
            get { return _cost; }
            set
            {
                if(value < MIN_COST)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Cost = value;
            }
        }
        void CheckString(string str)
        {
            if (str == string.Empty)
            {
                throw new FormatException();
            }
            if(str == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
