namespace task_DEV_4
{
    public class Plane : IFlyable
    {
        Point currentLocation;
        const int _startSpeed = 200;
        const int _maxspeed = 1500;
        public bool FlyTo(Point destintaion)
        {
            currentLocation = destintaion;
            return true;
        }
        public double GetFlyTime(Point destination)
        {
            int speed = _startSpeed;
            double time = 0;
            double traveled = 0;
            int speedIncrease;
            while (traveled < currentLocation.Distance(destination))
            {
                traveled += speed;
                if (speed < _maxspeed)
                {
                    speedIncrease = (int)traveled / 10;
                    speed = _startSpeed + speedIncrease;
                }
                else
                {
                    speed = _maxspeed;
                }
                time++;
            }
            if (traveled > currentLocation.Distance(destination))
            {
                time -= (traveled - currentLocation.Distance(destination)) / speed;
            }
            return time;
        }
        public Plane(Point destination)
        {
            currentLocation = destination;
        }
    }
}
