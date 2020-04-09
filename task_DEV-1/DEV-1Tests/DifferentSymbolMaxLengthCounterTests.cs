using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_1;
using System;


namespace DEV_1.Tests
{
    [TestClass()]
    public class DifferentSymbolMaxLengthCounterTests
    {
        [TestMethod()]
        [DataRow("hello world", 8)]
        [DataRow("hhh", 1)]
        [DataRow("1234441234566", 7)]
        public void StringDiffCountDifferentSymbolsCountingCorrectly(string str1, int expected)
        {
            int actual = DifferentSymbolMaxLengthCounter.CountDifferentSymbols(str1);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod()]
        [DataRow("H", 1)]
        [DataRow("", 0)]
        public void StringDiffCountDifferentSymbolsBorderConditions(string str1, int expected)
        {
            int actual = DifferentSymbolMaxLengthCounter.CountDifferentSymbols(str1);
            Assert.AreEqual(actual,expected);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException),"String is null")]
        public void StringDiffCountDifferentSymbolsNullString()
        {
            string str1 = null;
            DifferentSymbolMaxLengthCounter.CountDifferentSymbols(str1);
        }
        [TestMethod()]
        public void StringDiffCountDifferentSymbolsVeryLargeString()
        {
            string str1 = "start";
            int maxStringLength = 1073741823;
            while (maxStringLength / str1.Length > 1)
            {
                str1 += str1;
            }
            int actual= DifferentSymbolMaxLengthCounter.CountDifferentSymbols(str1);
            int expected = str1.Length ;
            Assert.AreEqual(actual, expected);
        }
    }
}