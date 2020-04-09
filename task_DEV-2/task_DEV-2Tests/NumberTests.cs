using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_DEV_2;
using System;

namespace task_DEV_2.Tests
{
    [TestClass()]
    public class NumberTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "SystemBase is out of range 2-20")]
        [DataRow(20, -4)]
        [DataRow(20, 1)]
        [DataRow(20, 21)]
        public void ConvertToAnotherBaseTestCorrectInput(int number10, int systemBase)
        {
            Number number = new Number(number10);
            number.ConvertToAnotherBase(systemBase);
        }
        [TestMethod()]
        [DataRow(20, 2, "10100")]
        [DataRow(-20, 2, "-10100")]
        [DataRow(-5, 16, "-5")]
        [DataRow(-14, 16, "-E")]
        public void ConvertToAnotherBaseTestCorrectCalculatingForInt(int number10, int systemBase, string expected)
        {
            string actual;
            Number number = new Number(number10);
            actual = number.ConvertToAnotherBase(systemBase);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        [DataRow("20", 2, "10100")]
        [DataRow("-20", 2, "-10100")]
        [DataRow("-5", 16, "-5")]
        [DataRow("-14", 16, "-E")]
        public void ConvertToAnotherBaseTestCorrectCalculatingForString(string number10, int systemBase, string expected)
        {
            string actual;
            Number number = new Number(number10);
            actual = number.ConvertToAnotherBase(systemBase);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException), "This object is null")]
        public void ConvertToAnotherBaseTestNullObjectInput()
        {
            Number number = null;
            number.ConvertToAnotherBase(15);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "One or more arguments are null")]
        public void ConvertToAnotherBaseTestNullStringInput()
        {
            Number number = new Number(null);
            number.ConvertToAnotherBase(5);
        }
        [TestMethod()]
        [DataRow("")]
        [DataRow(" ")]
        [DataRow("123a321")]
        [DataRow("123.321")]
        [DataRow("123-321")]
        [ExpectedException(typeof(FormatException), "Cant convert this string to integer")]
        public void ConvertToAnotherBaseTestIncorrectStringInput(string str)
        {
            Number number = new Number(str);
            number.ConvertToAnotherBase(5);
        }
    }
}