namespace task_DEV_3
{
    public class Truck : Vehicle
    {
        double _height;
        const double _minHeight = 1;
        const string _vehicleType = "Truck";
        public double Height
        {
            get { return _height; }
            set 
            {
                if (value < _minHeight)
                {
                    throw new System.ArgumentOutOfRangeException("Height can't be lower than " + _minHeight);
                }
                _height = value;
            }
        }
        public Truck(double height, Engine engine, Transmission transmission, Chassis chassis):base(engine, transmission, chassis,_vehicleType)
        {
            Height = height;
        }
        override public void GetInfo()
        {
            base.GetInfo();
            System.Console.WriteLine("Truck height is " + _height);
        }
    }
}
