using System;

namespace task_DEV_3
{
    public class Car : Vehicle
    {
        int _numberOfSeats;
        const int _minSeatsNumber = 1;
        const string _vehicleType = "Car";
        new public void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("\tNumber of seats is " + _numberOfSeats);
            
        }
        public Car(int numberOfSeats, Engine engine, Transmission transmission, Chassis chassis):base(engine,transmission,chassis,_vehicleType)
        {
            if (numberOfSeats < _minSeatsNumber)
            {
                throw new ArgumentException("Number of seats must be greater than "+_minSeatsNumber);
            }
            _numberOfSeats = numberOfSeats; 
        }
    }
}
