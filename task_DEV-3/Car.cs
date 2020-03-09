using System;

namespace task_DEV_3
{
    class Car : Vehicle
    {
        int _seatNum;
        new public void getInfo()
        {
            System.Console.WriteLine("Type: Car");
            System.Console.WriteLine("Number of seats is " + _seatNum);
            base.getInfo();
        }
        Car(int seatNum, Engine engine, Transmission transmission, Chassis chassis)
        {
            _seatNum = seatNum;
            VehicleInit(engine, transmission, chassis);
        }
    }
}
