using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise6;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest6
    {
        Spam interval1;
        Spam interval2;
        Spam interval3;

        [TestInitialize]
        public void TestInizializeClass()
        {
            interval1 = new Spam(5, 10);
            interval2 = new Spam(20, 40);
        }

        [TestMethod]
        public void TestInterval()
        {
            Assert.AreEqual(5, interval1.From);
            Assert.AreEqual(10, interval1.To);
            Assert.AreEqual(6, interval1.Length);
            Assert.AreEqual(20, interval2.From);
            Assert.AreEqual(40, interval2.To);
            Assert.AreEqual(21, interval2.Length);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestOutOfIndex()
        {
            interval3 = new Spam(2, 6);
            int i = interval3[10];
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestNotValoidIndex()
        {
            interval3 = new Spam(20, 10);
            int tryC = interval3[52];
        }

        [TestMethod]
        public void TestOperationSpam()
        {
            Spam intervalOP = interval1 - 2;
            Assert.AreEqual(3, intervalOP.From);
            intervalOP = interval1 + 5;
            Assert.AreEqual(15, intervalOP.To);
            intervalOP = interval1 * 2;
            Assert.AreEqual(11, intervalOP.Length);
            intervalOP = interval1 >> 1;
            Assert.AreEqual(11, intervalOP.To);
            intervalOP = interval1 << 1;
            Assert.AreEqual(6, intervalOP.From);
        }
    }
}
