namespace task_DEV_3
{
    class BuildCarAutoPetrol : IVehicleFactory
    {
        static int vehicleNumber = 0;
        public Vehicle BuildVehicle()
        {
            Engine engine = new Engine(200, 3, "Petrol", "Serial" + vehicleNumber);
            Transmission transmission = new Transmission("Automatic", "Vendor", 5);
            Chassis chassis = new Chassis(4, "Serial" + vehicleNumber, 2000);

            Vehicle vehicle = new Car(4, engine, transmission, chassis);
            vehicleNumber++;
            return vehicle;
        }
    }
    class BuildCarManual : IVehicleFactory
    {
        static int vehicleNumber = 0;
        public Vehicle BuildVehicle()
        {
            Engine engine = new Engine(200, 3.2, "Disel", "Serial" + vehicleNumber);
            Transmission transmission = new Transmission("Manual", "Vendor", 5);
            Chassis chassis = new Chassis(4, "Serial" + vehicleNumber, 2000);
            Vehicle vehicle = new Car(4, engine, transmission, chassis);
            vehicleNumber++;
            return vehicle;
        }
    }
}
