using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_1.Tests
{
    [TestClass()]
    public class StringDifTests
    {
        /// <summary>
        /// Checking if method is counting correctly
        /// </summary>
        [TestMethod()]
        public void StringDiffCountDifferentSymbols_CountingCorrectly()
        {
            string str1 = "hello world";
            int actual = StringDif.CountDifferentSymbols(str1);
            int expected = 8;
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// Checking if method works correctly with string containing only 1 symbol
        /// </summary>
        [TestMethod()]
        public void StringDiffCountDifferentSymbols_OneSymbol()
        {
            string str1 = "H";
            int actual = StringDif.CountDifferentSymbols(str1);
            int expected = 1;
            Assert.AreEqual(actual,expected);
        }
        /// <summary>
        /// Checking if method works correctly if string is empty
        /// </summary>
        [TestMethod()]
        public void StringDiffCountDifferentSymbols_EmptyString()
        {
            string str1 = "";
            int actual = StringDif.CountDifferentSymbols(str1);
            int expected = 0;
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// Checking if method works correctly if string is null
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException),"String is null")]
        public void StringDiffCountDifferentSymbols_NullString()
        {
            string str1 = null;
            StringDif.CountDifferentSymbols(str1);
        }
        /// <summary>
        /// Checking if method works correctly with large strings
        /// </summary>
        [TestMethod()]
        public void StringDiffCountDifferentSymbols_VeryLargeString()
        {
            string str1 = "start";
            while (1073741823 / str1.Length > 1)
            {
                str1 += str1;
            }
            int actual= StringDif.CountDifferentSymbols(str1);
            int expected = str1.Length ;
            Assert.AreEqual(actual, expected);
        }
    }
}