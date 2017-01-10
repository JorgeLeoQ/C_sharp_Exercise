using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise2;

namespace UnitTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestFibonacciZero()
        {
            BigInteger[] resultFibonacci = FibonacciClass.FibonacciSeq(0);
            Assert.AreEqual(0, resultFibonacci.Length, "Error in Fibonci[0]");
        }

        [TestMethod]
        public void TestFibonacciOne()
        {
            BigInteger[] resultFibonacci = FibonacciClass.FibonacciSeq(2);
            Assert.AreEqual(1, resultFibonacci[1], "Error in Fibonacci method.");
            Assert.AreEqual(0, resultFibonacci[0], "Error in Fibonacci method.");
        }

        [TestMethod]
        public void TestFibonacciTen()
        {
            BigInteger[] resultFibonacci = FibonacciClass.FibonacciSeq(10);
            Assert.AreEqual(34, resultFibonacci[9], "Error in Fibonacci method.");
            Assert.AreEqual(21, resultFibonacci[8], "Error in Fibonaci method.");
        }

        [TestMethod]
        public void TestFibonacci100()
        {
            BigInteger[] resultFibonacci = FibonacciClass.FibonacciSeq(100);
            Assert.AreEqual(75025, resultFibonacci[25], "Error in Fibonacci method.");
            Assert.AreEqual(100, resultFibonacci.Length, "Error in Fibonacci method");
        }
        [TestMethod]
        public void TestFibonacciArrey()
        {
            BigInteger[] resultFibonacci = FibonacciClass.FibonacciSeq(5);
            BigInteger[] TrueFibonacci = new BigInteger[] { 0, 1, 1, 2, 3 };
            CollectionAssert.AreEqual(TrueFibonacci, resultFibonacci);
        }
    }
}
