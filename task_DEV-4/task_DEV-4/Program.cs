using System;

namespace task_DEV_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Point p1 = new Point(20, 20, 20);
                Point p2 = new Point(20, 220, 20);
                Bird bird = new Bird(p1);
                Console.WriteLine(bird.GetFlyTime(p2));
                bird.FlyTo(p2);

                Drone drone = new Drone(p1);
                Console.WriteLine(drone.GetFlyTime(p2));
                drone.FlyTo(p2);

                Plane plane = new Plane(p1);
                Console.WriteLine(plane.GetFlyTime(p2));
                plane.FlyTo(p2);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }
    }
}
