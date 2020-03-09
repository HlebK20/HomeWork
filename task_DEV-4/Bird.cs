using System;
using System.Collections.Generic;
using System.Text;

namespace task_DEV_4
{
    class Bird: IFlyable
    {
        Point p;
        int speed;
        void IFlyable.FlyTo(Point p1)
        {
            p = p1;
        }
        double IFlyable.GetFlyTime(Point p1)
        {
            Random rnd = new Random();
            speed = rnd.Next(1,20);
            return p.Distance(p1) / speed;
        }
    }
}
