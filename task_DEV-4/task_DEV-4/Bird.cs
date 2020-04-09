using System;

namespace task_DEV_4
{
    public class Bird : IFlyable
    {
        Point _currentLocation;
        int _speed;
        const int MIN_SPEED = 0;
        const int MAX_SPEED = 20;
        public bool FlyTo(Point destination)
        {
            if (_speed == 0)
            {
                return false;
            }
            _currentLocation = destination;
            return true;
        }
        public TimeSpan GetFlyTime(Point destination)
        {
            if (_speed == MIN_SPEED)
            {
                throw new ArgumentOutOfRangeException("This bird can't fly. Speed is 0");
            }
            double time = _currentLocation.Distance(destination) / _speed;
            int timeInTicks = (int)(time * 3600 * Math.Pow(10, 7));
            TimeSpan timeSpan = new TimeSpan(timeInTicks);
            return timeSpan;
        }
        public Bird(Point currentLocation)
        {
            _currentLocation = currentLocation;
            Random rnd = new Random();
            _speed = rnd.Next(MIN_SPEED, MAX_SPEED);
        }
        public Bird(Point currentLocation, int speed)
        {
            _currentLocation = currentLocation;
            if (speed < MIN_SPEED || speed > MAX_SPEED)
            {
                throw new ArgumentOutOfRangeException("Speed can't be below " + MIN_SPEED + " and greater than " + MAX_SPEED);
            }
            _speed = speed;
        }
    }
}
