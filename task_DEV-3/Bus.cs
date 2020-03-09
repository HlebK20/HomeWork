namespace task_DEV_3
{
    class Bus : Vehicle
    {
        int _maxCount;
        new public void getInfo()
        {
            System.Console.WriteLine("Type: Bus");
            System.Console.WriteLine("Maximum passengers count is " + _maxCount);
            base.getInfo();
        }
        Bus(int maxCount, Engine engine, Transmission transmission, Chassis chassis)
        {
            _maxCount = maxCount;
            VehicleInit(engine, transmission, chassis);
        }
    }
}
