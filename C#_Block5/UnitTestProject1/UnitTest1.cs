using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        TaxHouse myHouse = new TaxHouse("InCity", true, 120f, 146000000.00m);
        TaxHouse outHouse = new TaxHouse("OutOfCity", false, 80f, 80000000.00M);
        TaxBus myBus = new TaxBus(20, 16240, 500000.00m);

        [TestMethod]
        public void TestHouseInCity()
        {
            Assert.AreEqual("InCity", myHouse.Location);
            Assert.AreEqual(120f, myHouse.Area);
            Assert.AreEqual(146600.00M, myHouse.TaxValue());
        }

        [TestMethod]
        public void TestHouseOutOfCity()
        {
            Assert.AreEqual("OutOfCity", outHouse.Location);
            Assert.AreEqual(80f, outHouse.Area);
            Assert.AreEqual(80080.00M, outHouse.TaxValue());
        }

        [TestMethod]
        public void TestBus()
        {
            Assert.AreEqual(20, myBus.NumberOfSeats);
            Assert.AreEqual(16240, myBus.RegistrationNumber);
            Assert.AreEqual(600.00M, myBus.TaxValue());
        }
    }
}
