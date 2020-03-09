namespace task_DEV_3
{
    class Truck : Vehicle
    {
        double _height;
        new public void getInfo()
        {
            System.Console.WriteLine("Type: Truck");
            System.Console.WriteLine("Truck height is " + _height);
            base.getInfo();
        }
        Truck(double height, Engine engine, Transmission transmission, Chassis chassis)
        {
            _height = height;
            VehicleInit(engine, transmission, chassis);
        }
    }
}
