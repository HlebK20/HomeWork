namespace task_DEV_3
{
    class Scooter : Vehicle
    {
        string _material;
        new public void getInfo()
        {
            System.Console.WriteLine("Type: Scooter");
            System.Console.WriteLine("This scooter is made of " + _material);
            base.getInfo();
        }
        public Scooter(string material, Engine engine, Transmission transmission, Chassis chassis):base(engine,transmission,chassis)
        {
            _material = material;
        }
    }
}
