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
        public Truck(double height, Engine engine, Transmission transmission, Chassis chassis):base(engine, transmission, chassis)
        {
            _height = height;
        }
    }
}
