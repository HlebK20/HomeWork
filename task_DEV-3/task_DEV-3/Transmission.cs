﻿using System;

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
        private void CheckNullOrEmpty(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Argument is null");
            }
            if (value.GetType() == typeof(string) && (string)value == string.Empty)
            {
                throw new FormatException("String is empty");
            }
        }
    }
}