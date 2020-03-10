    using System;
using System.Collections.Generic;
using System.Text;

namespace task_DEV_4
{
    
    class Drone : IFlyable
    {
        Point _point;
        int _speed;
        public void FlyTo(Point p1)
        {
            if (_point.Distance(p1) <= 1000)
                _point = p1;
        }
        public double GetFlyTime(Point p1)
        {
            double time = 0;
            time = _point.Distance(p1) / _speed *(10+1) / 10 ;
            return time;
        }
        public Drone(Point point, int speed)
        {
            _point = point;
            _speed = CheckBelowZero(speed);
        }
        int CheckBelowZero(int valve)
        {
            if (valve >= 0)
                return valve;
            throw new ArgumentException();
        }
    }
}
