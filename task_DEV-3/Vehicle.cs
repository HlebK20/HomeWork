namespace task_DEV_3
{
    abstract class Vehicle
    {
        Engine _Engine;
        Transmission _Trnansmission;
        Chassis _Chassis;
        protected void getInfo()
        {
            System.Console.WriteLine("Engine is " + _Engine);
            System.Console.WriteLine("Transmission is " + _Trnansmission);
            System.Console.WriteLine("Chassis is " + _Chassis);
        }
        protected void VehicleInit(Engine engine, Transmission transmission, Chassis chassis)
        {
            _Engine = engine;
            _Trnansmission = transmission;
            _Chassis = chassis;
        }
    }
}
