using System;

namespace task_DEV_4
{
    class Bird : IFlyable
    {
        Point _currentLocation;
        int _speed;
        public bool FlyTo(Point destination)
        {
            if (_speed == 0)
            {
                return false;
            }
            _currentLocation = destination;
            return true;
        }
        public double GetFlyTime(Point destination)
        {
            if (_speed == 0)
            {
                throw new ArgumentException("This bird can't fly. Speed is 0");
            }
            return _currentLocation.Distance(destination) / _speed;
        }
        public Bird(Point currentLocation)
        {
            _currentLocation = currentLocation;
            Random rnd = new Random();
            _speed = rnd.Next(0, 20);
        }
    }
}
