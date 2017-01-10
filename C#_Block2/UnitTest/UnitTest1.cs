using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise1;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGreater()
        {
            const int num1 = 10;
            const int num2 = 5;
            Assert.AreEqual(10, GreaterAndSmaller.Greater(num1, num2), "Error, in Greater method");
        }

        [TestMethod]
        public void TestSmaller()
        {
            const int number1 = 10;
            const int number2 = 5;
            Assert.AreEqual(5, GreaterAndSmaller.Smaller(number1, number2), "Error, in Smaller method");
        }

        [TestMethod]
        public void TestNegativeSmaller1()
        {
            const int number1 = 2;
            const int number2 = -2;
            Assert.AreEqual(-2, GreaterAndSmaller.Smaller(number1, number2), "Error, in Smaller method");
        }

        [TestMethod]
        public void TestNegativeSmaller2()
        {
            const int number1 = -2;
            const int number2 = -6;
            Assert.AreEqual(-6, GreaterAndSmaller.Smaller(number1, number2), "Error, in Smaller method");
        }

        [TestMethod]
        public void TestNegativeGreater()
        {
            const int number1 = -1;
            const int number2 = -9;
            Assert.AreEqual(-1, GreaterAndSmaller.Greater(number1, number2), "Error, in Greater method");
        }

        [TestMethod]
        public void TestEqualNumber()
        {
            const int number1 = 0;
            const int number2 = 0;
            Assert.AreEqual(0, GreaterAndSmaller.Greater(number1, number2), "Error, in Greater method.");
            Assert.AreEqual(0, GreaterAndSmaller.Smaller(number1, number1), "Error, in Smaller method");
        }
    }
}
