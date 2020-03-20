namespace task_DEV_3
{
    public class Bus : Vehicle
    {
        int _maxPassengers;
        const int _minPassengers = 1;
        const string _vehicleType = "Bus";

        public int MaxPassengers
        {
            get { return _maxPassengers; }
            set
            {
                if (value < _minPassengers)
                {
                    throw new System.ArgumentOutOfRangeException("Maximum passengers can't be lower than " + _minPassengers);
                }
                _maxPassengers = value;
            }
        }
        public Bus(int maxPassengers, Engine engine, Transmission transmission, Chassis chassis): base(engine,transmission,chassis,_vehicleType)
        {
            MaxPassengers = maxPassengers;
        }
        new public void GetInfo()
        {
            base.GetInfo();
            System.Console.WriteLine("\tMaximum passengers count is " + _maxPassengers);
        }
    }
}
