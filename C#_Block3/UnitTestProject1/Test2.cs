using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise2;

namespace UnitTestProject
{
    [TestClass]
    public class Test2
    {
        [TestMethod]
        public void TestSumEqualNumber()
        {
            string number1 = "150";
            string number2 = "150";
            string result = "300";
            Assert.AreEqual(result, SumLongIntegers.SumLong(number1, number2));
        }

        [TestMethod]
        public void TestSumNoLong1()
        {
            string number1 = "10";
            string number2 = "20";
            string result = "30";
            Assert.AreEqual(result, SumLongIntegers.SumLong(number1, number2));
        }

        [TestMethod]
        public void TestSumNoLong2()
        {
            string number1 = "90";
            string number2 = "10";
            string result = "100";
            Assert.AreEqual(result, SumLongIntegers.SumLong(number1, number2));
        }

        [TestMethod]
        public void TestSumLong1()
        {
            string number1 = "123456789123456789123456789";
            string number2 = "123";
            string result = "123456789123456789123456912";
            Assert.AreEqual(result, SumLongIntegers.SumLong(number1, number2));
        }

        [TestMethod]
        public void TestSumLong2()
        {
            string number1 = "1";
            string number2 = "1000000000000000000000000000000000000000000000000000000000000000000";
            string result = "1000000000000000000000000000000000000000000000000000000000000000001";
            Assert.AreEqual(result, SumLongIntegers.SumLong(number1, number2));
        }
    }
}
