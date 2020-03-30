using System;

namespace task_DEV_4
{
    public class Plane : IFlyable
    {
        Point currentLocation;
        const int START_SPEED = 200;
        const int MAX_SPEED = 1500;
        const int MIN_FLYING_DISTANCE = 10;
        public bool FlyTo(Point destination)
        {
            if(currentLocation.Distance(destination) < MIN_FLYING_DISTANCE)
            {
                return false;
            }
            currentLocation = destination;
            return true;
        }
        public TimeSpan GetFlyTime(Point destination)
        {
            if (currentLocation.Distance(destination) < MIN_FLYING_DISTANCE)
            {
                throw new ArgumentOutOfRangeException("Distance can't be lower than "+MIN_FLYING_DISTANCE);
            }
            int speed = START_SPEED;
            double time = 0;
            double traveled = 0;
            int speedIncrease;
            while (traveled < currentLocation.Distance(destination))
            {
                traveled += speed;
                if (speed < MAX_SPEED)
                {
                    speedIncrease = (int)traveled / 10;
                    speed = START_SPEED + speedIncrease;
                }
                else
                {
                    speed = MAX_SPEED;
                }
                time++;
            }
            if (traveled > currentLocation.Distance(destination))
            {
                time -= (traveled - currentLocation.Distance(destination)) / speed;
            }
            int timeInTicks = (int)(time * 3600 * Math.Pow(10, 7));
            TimeSpan timeSpan = new TimeSpan(timeInTicks);
            return timeSpan;
        }
        public Plane(Point destination)
        {
            currentLocation = destination;
        }
    }
}
