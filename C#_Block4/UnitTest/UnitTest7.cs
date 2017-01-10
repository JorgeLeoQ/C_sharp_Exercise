using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise7;

namespace UnitTest
{
    [TestClass]
    public class UnitTest7
    {
        [TestMethod]
        [ExpectedException(typeof(BirthFutereException))]
        public void TestMethod1()
        {
            Person firstPerson = new Person("Giulia", "Rossi", new DateTime(2017, 2, 21), "giulia.rossi@libero.it");
        }

        [TestMethod]
        [ExpectedException(typeof(TooOldBirthException))]
        public void TestTooOld()
        {
            Person firstPerson = new Person("Giulia", "Rossi", new DateTime(1900, 9, 12), "giulia.rossi@libero.it");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestWrongEmail()
        {
            Person firstPerson = new Person("Giulia", "Rossi", new DateTime(1980, 9, 13), "wrongEmail");
        }

        [TestMethod]
        public void TestOnePerson()
        {
            Person Joe = new Person("Joe", "Doe", new DateTime(1980, 2, 25), "joe.Doe80@gmail.com");
            Assert.IsTrue(Joe.Adult);
            Assert.IsFalse(Joe.Birthday);
            Assert.AreEqual("Monkey", Joe.MyChineseZodiacal);
            Assert.AreEqual("Your zodiac sign is Pisces", Joe.MyZodiac);
            Assert.AreEqual("Joe Doe born on 2 25th 1980", Joe.ScreenName);
        }

        [TestMethod]
        public void TestSecondPerson()
        {
            Person Leo = new Person("Leonardo", "Quimi", new DateTime(1994, 7, 18));
            Assert.AreEqual("Example@unige.it", Leo.Email.ToString()); //default email
        }
    }
}
