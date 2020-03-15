using Microsoft.VisualStudio.TestTools.UnitTesting;
using Point;
using System;
using System.Collections.Generic;
using System.Text;

namespace Point.Tests
{
    [TestClass]
    public class PointTests
    {
        [DataTestMethod]
        [DataRow(-1, 1 , 1)]
        [DataRow(1,-1,1)]
        [DataRow(1,1,-1)]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Some coordinates are below zero")]
        public void CheckIfPointCoordinatesBelowZero(float Coordinate1, float Coordinate2, float Coordinate3)
        {
            Point p = new Point(Coordinate1, Coordinate2, Coordinate3);
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException),"One or more objects are null")]
        public void CheckPointEqualsAnyIsNull()
        {
            Point p = new Point(1,2,3);
            Point p1 = null;
            bool actual = p1.Equals(p1);
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void CheckPointEqualsTwoSamePoints()
        {
            Point p = new Point(1, 2, 3);
            Point p1 = new Point(1,2,3);
            bool actual = p.Equals(p1);
            Assert.IsTrue(actual);
        }
        [DataTestMethod]
        [DataRow("String")]
        [DataRow(10)]
        [DataRow(10.1)]
        [DataRow('a')]
        public void CheckPointEqualsObjectType(object obj)
        {
            Point p = new Point(1, 2, 3);
            bool actual = p.Equals(obj);
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void CheckPointDistanceCorrectAnswer()
        {
            Point p = new Point(0, 0, 0);
            Point p1 = new Point(1, 1, 1);

            bool actual = Equals(p.Distance(p1), (float)Math.Sqrt(3));

            Assert.IsTrue(actual);
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException),"Point is null")]
        public void CheckPointDistanceNullArgument()
        {
            Point p = new Point(0, 0, 0);
            Point p1 = null;
            p.Distance(p1);
        }

    }
}