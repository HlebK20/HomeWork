using System;
using System.Collections.Generic;

namespace task_DEV_3
{
    class Program
    {
        static void Main()
        {
            try
            {
                //Engine engine = new Engine(2.5, 2.9, "SomeTypeOfEngine", "25OHC");
                //Transmission transmission = new Transmission("SomeTypeOfTransmission", "IDKinc", 6);
                //Chassis chassis = new Chassis(4, "123CDF", 1270);
                //Car car = new Car(4, engine, transmission, chassis);
                //car.GetInfo();

                List<Vehicle> vehicles = new List<Vehicle>();
                var carAutoPetrolBuilder = new BuildCarAutoPetrol();
                var carManualBuilder = new BuildCarManual();
                var bus45SeatsBuilder = new BuildBus45Seats();
                var truckAutoBuilder = new BuildTruckAuto();
                while (vehicles.Count<16)
                {
                    vehicles.Add(carAutoPetrolBuilder.BuildVehicle());
                    vehicles.Add(carManualBuilder.BuildVehicle());
                    vehicles.Add(bus45SeatsBuilder.BuildVehicle());
                    vehicles.Add(truckAutoBuilder.BuildVehicle());
                }
            }
            catch(Exception Exc)
            {
                Console.WriteLine(Exc.Message);
            }
        }
    }

}
