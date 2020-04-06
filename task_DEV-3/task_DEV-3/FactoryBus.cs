
namespace task_DEV_3
{
    class BuildBus45Seats : IVehicleFactory
    {
        static int vehicleNumber = 0;
        public Vehicle BuildVehicle()
        {
            Engine engine = new Engine(500, 10, "Petrol", "Serial" + vehicleNumber);
            Transmission transmission = new Transmission("Automatic", "Vendor", 5);
            Chassis chassis = new Chassis(4, "Serial" + vehicleNumber, 2000);

            Vehicle vehicle = new Bus(45, engine, transmission, chassis);
            vehicleNumber++;
            return vehicle;
        }
    }
}
