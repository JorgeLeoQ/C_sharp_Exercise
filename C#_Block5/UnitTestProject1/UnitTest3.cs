using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestTwoSixesEvent()
        {

            Die die = new Die();
            bool causeEvent = false;

            for (int i = 1; i < 1000; i++)
            {
                die.Toss();
                die.twoSixesInARow += delegate ()
                {
                    causeEvent = true;
                };
            }

            Assert.IsTrue(causeEvent);
        }

        [TestMethod]
        public void TestFullHouse()
        {
            Die die = new Die();
            int counterEve = 0;

            for (int i = 0; i < 1000; i++)
            {

                die.Toss();
                die.fullHouse += delegate ()
                {
                    counterEve++;
                };

            }
            Assert.IsFalse(counterEve == 0);
        }

    }
}
