using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise6;

namespace UnitTest
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void TestTostring()
        {
            int hoursTrue = 10;
            int minutesTrue = 5;
            int minutesTotTrue = 605;
            Time t1 = new Time(10,5);
            string stringTrue;
            stringTrue = String.Format("The time {0}:{1} corresponding at {2} total minutes", hoursTrue, minutesTrue, minutesTotTrue);
            Assert.AreEqual(stringTrue,t1.ToString());
        }
        [TestMethod]
        public void TestSumTime()
        {
            Time t1 = new Time(12,0);
            Time t2 = new Time(12,0);
            Time tTrue = new Time(0,0);
            Time tSum = t1 + t2;
            Assert.AreEqual(tSum,tTrue);
        }
        [TestMethod]
        public void TestSubTime()
        {
            Time t1 = new Time(10,5);
            Time t2 = new Time(3,5);
            Time tTrue = new Time(7, 0);
            Time tSum = t1 - t2;
            Assert.AreEqual(tTrue,tSum);
        }
        [TestMethod]
        public void TestExplicitConvIntToTime()
        {
            Time t1 = new Time(2, 0);
            int minTot = (int)t1;
            Assert.AreEqual(120, t1);
        }
        [TestMethod]
        public void TestImplicitConvTimeToInt()
        {
            Time t1 = 121;
            Time tTrue = new Time(2,1);
            Assert.AreEqual(tTrue,t1);
        }

    }
}