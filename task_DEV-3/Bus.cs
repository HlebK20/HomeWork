namespace task_DEV_3
{
    class Bus : Vehicle
    {
        int _maxPassengers;
        new public void GetInfo()
        {
            System.Console.WriteLine("Type: Bus");
            System.Console.WriteLine("Maximum passengers count is " + _maxPassengers);
            base.GetInfo();
        }
        public Bus(int maxPassengers, Engine engine, Transmission transmission, Chassis chassis): base(engine,transmission,chassis)
        {
            _maxPassengers = maxPassengers;
        }
    }
}
