﻿namespace task_DEV_3
{
    public class Scooter : Vehicle
    {
        string _material;
        const string _vehicleType = "Scooter";
        public string Material
        {
            get { return _material; }
            set 
            {
                base.CheckValid(value);
                _material = value;
            }
        }
        public Scooter(string material, Engine engine, Transmission transmission, Chassis chassis):base(engine,transmission,chassis,_vehicleType)
        {
            base.CheckValid(material);
            Material = material;
        }
        override public void GetInfo()
        {
            base.GetInfo();
            System.Console.WriteLine("\tThis scooter is made of " + _material);
        }
    }
}
