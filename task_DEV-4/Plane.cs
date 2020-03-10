using System;
using System.Collections.Generic;
using System.Text;

namespace task_DEV_4
{
    class Plane : IFlyable
    {
        Point p;
        int speed;
        public void FlyTo(Point p1)
        {
            p = p1;
        }
        public double GetFlyTime(Point p1)
        {
            return 0;
        }
    }
}
