using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise4;

namespace UnitTestProject1
{
    [TestClass]
    public class Test4
    {
        [TestMethod]
        public void TestSimpleWeek()
        {
            DateTime startDay = new DateTime(DateTime.Now.Year, 1, 18);
            DateTime endDay = new DateTime(DateTime.Now.Year, 1, 22);
            Assert.AreEqual(5, Workdays.HowManyDays(startDay, endDay), "There are some problem in Workdays class.");
        }

        [TestMethod]
        public void TestSimpleWeekWithHoliday()
        {
            DateTime startDay = new DateTime(DateTime.Now.Year, 4, 25);
            DateTime endDay = new DateTime(DateTime.Now.Year, 4, 29);
            Assert.AreEqual(4, Workdays.HowManyDays(startDay, endDay), "There are some problem in Workdays class.");
        }

        [TestMethod]
        public void TestWeekendWithoutWorkingSaturday()
        {
            DateTime startDay = new DateTime(DateTime.Now.Year, 6, 18);
            DateTime endDay = new DateTime(DateTime.Now.Year, 6, 19);
            Assert.AreEqual(0, Workdays.HowManyDays(startDay, endDay), "There are some problem in Workdays class.");
        }

        [TestMethod]
        public void TestWeekendWithWorkingSaturday()
        {
            DateTime startDay = new DateTime(DateTime.Now.Year, 11, 5);
            DateTime endDay = new DateTime(DateTime.Now.Year, 11, 6);
            Assert.AreEqual(1, Workdays.HowManyDays(startDay, endDay), "There are some problem in Workdays class.");
        }

        [TestMethod]
        public void TestOneMouth()
        {
            DateTime startDay = new DateTime(DateTime.Now.Year, 10, 1);
            DateTime endDay = new DateTime(DateTime.Now.Year, 10, 31);
            Assert.AreEqual(22, Workdays.HowManyDays(startDay, endDay), "There are some problem in Workdays class.");

        }

        [TestMethod]
        public void TestSixMouth()
        {
            DateTime startDay = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime endDay = new DateTime(DateTime.Now.Year, 6, 30);
            Assert.AreEqual(132, Workdays.HowManyDays(startDay, endDay), "There are some problem in Workdays class.");

        }

        [TestMethod]
        public void TestOneYear()
        {
            DateTime startDay = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime endDay = new DateTime(DateTime.Now.Year, 12, 31);
            Assert.AreEqual(263, Workdays.HowManyDays(startDay, endDay), "There are some problem in Workdays class.");
        }

        [TestMethod]
        public void TestChristmasWeek()
        {
            DateTime startDay = new DateTime(DateTime.Now.Year, 12, 21);
            DateTime endDay = new DateTime(DateTime.Now.Year, 12, 28);
            Assert.AreEqual(5, Workdays.HowManyDays(startDay, endDay), "There are some problem in Workdays class.");

        }
    }
}
