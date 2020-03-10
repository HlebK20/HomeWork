namespace task_DEV_3
{
    abstract class Vehicle
    {
        Engine _engine;
        Transmission _transmission;
        Chassis _chassis;
        protected void getInfo()
        {
            System.Console.WriteLine("Engine is " + _engine);
            System.Console.WriteLine("Transmission is " + _transmission);
            System.Console.WriteLine("Chassis is " + _chassis);
        }
        protected Vehicle(Engine engine, Transmission transmission, Chassis chassis)
        {
            _engine = engine;
            _transmission = transmission;
            _chassis = chassis;
        }
    }
}
