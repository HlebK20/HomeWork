using System;

namespace task_DEV_4
{
    interface IFlyable
    {
        bool FlyTo(Point destination);
        TimeSpan GetFlyTime(Point destination);
    }
}
