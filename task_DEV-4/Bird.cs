using System;
using System.Collections.Generic;
using System.Text;

namespace task_DEV_4
{
    class Bird: IFlyable
    {
        Point _point;
        int _speed;
        public void FlyTo(Point p1)
        {
            _point = p1;
        }
        public double GetFlyTime(Point p1)
        {
            Random rnd = new Random();
            _speed = rnd.Next(1,20);
            return _point.Distance(p1) / _speed;
        }
        public Bird(Point point, int speed)
        {
            _point = point;
            _speed = speed;
        }
    }
}
