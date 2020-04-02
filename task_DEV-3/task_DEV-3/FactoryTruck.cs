using System;
using System.Collections.Generic;
using System.Text;

namespace task_DEV_3
{
    class BuildTruckAuto : IVehicleFactory
    {
        static int vehicleNumber = 0;
        public Vehicle BuildVehicle()
        {
            Engine engine = new Engine(700, 16, "Petrol", "Serial" + vehicleNumber);
            Transmission transmission = new Transmission("Automatic", "Vendor", 5);
            Chassis chassis = new Chassis(4, "Serial" + vehicleNumber, 2000);

            Vehicle vehicle = new Truck(4, engine, transmission, chassis);
            vehicleNumber++;
            return vehicle;
        }
    }
}
