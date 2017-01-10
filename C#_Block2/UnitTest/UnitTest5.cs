using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise5;

namespace UnitTest
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestSumNZero()
        {
            int n = 0;
            int x = 1;
            Assert.AreEqual(1, SumPolynomio.PolynomialSum(x, n), "Error in the sum method");
        }

        [TestMethod]
        public void TestNegativeX()
        {
            int n = 1;
            int x = -2;
            Assert.AreEqual(0.5, SumPolynomio.PolynomialSum(x, n), "Error in the sum method");
        }

        [TestMethod]
        public void TestPositiveX()
        {
            int n = 1;
            int x = 2;
            Assert.AreEqual(1.5, SumPolynomio.PolynomialSum(x, n), "Error in the sum method");
        }
    }
}
