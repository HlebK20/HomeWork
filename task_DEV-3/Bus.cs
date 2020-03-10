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
        public Bus(int maxCount, Engine engine, Transmission transmission, Chassis chassis): base(engine,transmission,chassis)
        {
            _maxCount = maxCount;
        }
    }
}
