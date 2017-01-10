using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise8;

namespace UnitTest
{
    [TestClass]
    public class UnitTest8
    {
        [TestMethod]
        public void TestGreatestCommonDivisro()
        {
            int number1 = 54;
            int number2 = 24;
            Assert.AreEqual(6, GCDandLCM.Gcd(number1, number2), "Error in Greatest common divisor method.");
        }

        [TestMethod]
        public void TestLeastCommonMultiple()
        {
            int number1 = 6;
            int number2 = 3;
            Assert.AreEqual(6, GCDandLCM.Lcm(number1, number2), "Error in the less common multipler method.");
        }

        [TestMethod]
        public void TestEqualNumberGCD()
        {
            int number1 = 0;
            int number2 = 0;
            Assert.AreEqual(0, GCDandLCM.Gcd(number1, number2), "Error in the Greatest common divisor method.");
            number1 = 4;
            number2 = 4;
            Assert.AreEqual(4, GCDandLCM.Gcd(number1, number2), "Error in the Greatest common divisior method."); 
        }

        [TestMethod]
        public void TestEqualNumberLCM()
        {
            int number1 = 0;
            int number2 = 0;
            Assert.AreEqual(0, GCDandLCM.Lcm(number1, number2), "Error in the Less common multipler method.");
            number1 = 4;
            number2 = 4;
            Assert.AreEqual(4, GCDandLCM.Lcm(number1, number2), "Error in the Less common multiple method.");
        }

        [TestMethod]
        public void TestNumberNegative()
        {
            int number1 = -3;
            int number2 = -6;
            Assert.AreEqual(-6, GCDandLCM.Lcm(number1, number2), "Error with the negative number in Lcm Method.");
            Assert.AreEqual(-3, GCDandLCM.Gcd(number1, number2), "Error with the negative number in Gcd method.");
        }
    }
}
