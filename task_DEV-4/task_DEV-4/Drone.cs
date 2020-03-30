using System;

namespace task_DEV_4
{

    public class Drone : IFlyable
    {
        Point _currentLocation;
        const int _speed = 20;
        const int stopsEvery = 10;
        const int stopsDuration = 1;
        const int maxFlyDistance = 1000;
        public bool FlyTo(Point destination)
        {
            if (_currentLocation.Distance(destination) <= maxFlyDistance)
            {
                _currentLocation = destination;
                return true;
            }
            return false;
        }
        public double GetFlyTime(Point destination)
        {
            if (_currentLocation.Distance(destination) > maxFlyDistance)
            {
                throw new ArgumentOutOfRangeException("Drone cant fly distances more than 1000");
            }
            double time;
            time = _currentLocation.Distance(destination) / _speed;
            int stopsCount = (int)time / stopsEvery;
            time += stopsCount * stopsDuration;
            return time;
        }
        public Drone(Point currentLocation)
        {
            _currentLocation = currentLocation;
        }
    }
}
