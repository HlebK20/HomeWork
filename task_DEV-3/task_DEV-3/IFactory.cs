namespace task_DEV_3
{
    interface IVehicleFactory
    {
        static int vehicleNumber=0;
        Vehicle BuildVehicle();
    }
}
