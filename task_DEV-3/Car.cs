using System;

namespace task_DEV_3
{
    class Car : Vehicle
    {
        int _numberOfSeats;
        new public void GetInfo()
        {
            Console.WriteLine("Type: Car");
            Console.WriteLine("Number of seats is " + _numberOfSeats);
            base.GetInfo();
        }
        public Car(int numberOfSeats, Engine engine, Transmission transmission, Chassis chassis):base(engine,transmission,chassis)
        {
            if (numberOfSeats < 1)
            {
                throw new ArgumentException();
            }
            _numberOfSeats = numberOfSeats; 
        }
    }
}
