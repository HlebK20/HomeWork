namespace task_DEV_3
{
    public class Truck : Vehicle
    {
        double _height;
        const string _vehicleType = "Truck";
        new public void GetInfo()
        {
            base.GetInfo();
            System.Console.WriteLine("Truck height is " + _height);
        }
        public Truck(double height, Engine engine, Transmission transmission, Chassis chassis):base(engine, transmission, chassis,_vehicleType)
        {
            _height = height;
        }
    }
}
