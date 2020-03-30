using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_DEV_4;
using System;

namespace task_DEV_4.Tests
{
    [TestClass()]
    public class BirdFlyTests
    {
        Point location = new Point(20, 20, 20);
        Point destination = new Point(20, 220, 20);
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BirdGetFlyTimeThrowExceptionIfSpeedIs0Test()
        {
            Bird bird = new Bird(location, 0);
            bird.GetFlyTime(destination);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataRow(-1)]
        [DataRow(21)]
        public void BirdConstructorThrowExceptionIfSpeedLowerThan0orGreaterThan20Test(int speed)
        {
            Bird bird = new Bird(location, speed);
        }
        [TestMethod]
        public void BirdFlyToReturnsFalseIfSpeedIs0Test()
        {
            Bird bird = new Bird(location, 0);
            bool actual = bird.FlyTo(destination);
            Assert.IsFalse(actual);
        }
    }
    [TestClass]
    public class DroneFlyTests
    {
        Point location = new Point(20, 20, 20);
        Point destination = new Point(20, 220, 20);
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DroneGetFlyTimeThrowExceptionIfDistanceIsGreaterThan1000Test()
        {
            destination.PointY = 1500;
            Drone drone = new Drone(location);
            drone.GetFlyTime(destination);
        }
        [TestMethod]
        public void DroneFlyToReturnsFalseIfDistanceIsGreaterThan1000Test()
        {
            destination.PointY = 1500;
            Drone drone = new Drone(location);
            bool actual = drone.FlyTo(destination);
            Assert.IsFalse(actual);
        }
    }
    [TestClass]
    public class PlaneFlyTests
    {
        Point location = new Point(20, 20, 20);
        Point destination = new Point(20, 220, 20);
        [TestMethod]
        public void PlaneFlyToReturnsFalseIfDistanceIsLowerThanMinimalTest()
        {
            Plane plane = new Plane(destination);
            bool actual = plane.FlyTo(destination);
            Assert.IsFalse(actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PlaneGetFlyTimeThrowExceptionIfDistanceIsLowerThanMinimalTest()
        {
            Plane plane = new Plane(destination);
            plane.GetFlyTime(destination);
        }
    }
}
