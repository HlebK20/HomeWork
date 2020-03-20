using System;

namespace task_DEV_3
{
    public class Car : Vehicle
    {
        int _seatsNumber;
        const int _minSeatsNumber = 1;
        const string _vehicleType = "Car";
        public int SeatsNumber
        {
            get { return _seatsNumber; }
            set 
            {
                if (value < _minSeatsNumber)
                {
                    throw new ArgumentOutOfRangeException("Number of seats can't be lower than " + _minSeatsNumber);
                }
                _seatsNumber = value;
            }
        }
        public Car(int numberOfSeats, Engine engine, Transmission transmission, Chassis chassis):base(engine,transmission,chassis,_vehicleType)
        { 
            SeatsNumber = numberOfSeats; 
        }
        new public void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("\tNumber of seats is " + _seatsNumber);

        }
    }
}
