using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise1;

namespace unitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGreaterThanNeighborsTrue1()
        {
            int[] array = new int[] { 1, 3, 2 };
            Assert.AreEqual(true, GreaterNeighbors.GreaterThanNeighbors(array, 1));
        }

        [TestMethod]
        public void TestGreaterThanNeighborsTrue2()
        {
            int[] array = new int[] { 1 };
            Assert.AreEqual(true, GreaterNeighbors.GreaterThanNeighbors(array, 0));
        }

        [TestMethod]
        public void TestGreaterThanNeighborsFalse()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Assert.AreEqual(false, GreaterNeighbors.GreaterThanNeighbors(array, 3));
        }

        [TestMethod]
        public void TestFindFirstGreater1()
        {
            int[] array = new int[] { 1, 3, 2 };
            Assert.AreEqual(1, GreaterNeighbors.FindFirstGreaterThatNeighbor(array));
        }

        [TestMethod]
        public void TestFindFirstGreater2()
        {
            int[] array = new int[] { 1 };
            Assert.AreEqual(0, GreaterNeighbors.FindFirstGreaterThatNeighbor(array));
        }

        [TestMethod]
        public void TestNotFindGreater()
        {
            int[] array = new int[] { 4, 4, 4 };
            Assert.AreEqual(-1, GreaterNeighbors.FindFirstGreaterThatNeighbor(array));
        }
    }
}
