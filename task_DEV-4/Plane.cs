using System;
using System.Collections.Generic;
using System.Text;

namespace task_DEV_4
{
    class Plane : IFlyable
    {
        Point _point;
        int _speed;
        int _maxspeed;
        public void FlyTo(Point destintaion)
        {
            _point = destintaion;
        }
        public double GetFlyTime(Point destination)
        {
            double time=0;
            double traveled = 0;
            int increase = 0;
            while (traveled <= _point.Distance(destination))
            {
                traveled += _speed;
                if (_speed < _maxspeed)
                {
                    increase = (int)(_speed / 10);
                    _speed += increase;
                }
                time++;
            }
            _speed = 0;
            return time;
        }
        public Plane(Point point, int speed, int maxspeed)
        {
            _point = point;
            _speed = CheckBelowZero(speed);
            _maxspeed = CheckBelowZero(maxspeed);
        }
        int CheckBelowZero(int valve)
        {
            if (valve >= 0)
                return valve;
            throw new ArgumentException();
        }
    }
}
