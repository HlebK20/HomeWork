namespace task_DEV_3
{
    public class Bus : Vehicle
    {
        int _maxPassengers;
        const string _vehicleType = "Bus";
        new public void GetInfo()
        {
            base.GetInfo();
            System.Console.WriteLine("Maximum passengers count is " + _maxPassengers);
        }
        public Bus(int maxPassengers, Engine engine, Transmission transmission, Chassis chassis): base(engine,transmission,chassis,_vehicleType)
        {
            _maxPassengers = maxPassengers;
        }
    }
}
