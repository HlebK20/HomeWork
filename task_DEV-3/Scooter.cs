namespace task_DEV_3
{
    public class Scooter : Vehicle
    {
        string _material;
        const string _vehicleType = "Scooter";
        new public void GetInfo()
        {
            base.GetInfo();
            System.Console.WriteLine("This scooter is made of " + _material);
        }
        public Scooter(string material, Engine engine, Transmission transmission, Chassis chassis):base(engine,transmission,chassis,_vehicleType)
        {
            base.CheckForNullAndEmpty(material);
            _material = material;
        }
    }
}
