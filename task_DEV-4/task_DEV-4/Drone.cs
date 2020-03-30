using System;

namespace task_DEV_4
{

    public class Drone : IFlyable
    {
        Point _currentLocation;
        const int _speed = 20;
        const int STOPS_EVERY = 10;
        const int STOPS_DURATION = 1;
        const int MAX_FLY_DISTANCE = 1000;
        public bool FlyTo(Point destination)
        {
            if (_currentLocation.Distance(destination) <= MAX_FLY_DISTANCE)
            {
                _currentLocation = destination;
                return true;
            }
            return false;
        }
        public double GetFlyTime(Point destination)
        {
            if (_currentLocation.Distance(destination) > MAX_FLY_DISTANCE)
            {
                throw new ArgumentOutOfRangeException("Drone cant fly distances more than "+MAX_FLY_DISTANCE);
            }
            double time;
            time = _currentLocation.Distance(destination) / _speed;
            int stopsCount = (int)time / STOPS_EVERY;
            time += stopsCount * STOPS_DURATION;
            return time;
        }
        public Drone(Point currentLocation)
        {
            _currentLocation = currentLocation;
        }
    }
}
