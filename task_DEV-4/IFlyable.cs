namespace task_DEV_4
{
    interface IFlyable
    {
        bool FlyTo(Point destination);
        double GetFlyTime(Point destination);
    }
}
