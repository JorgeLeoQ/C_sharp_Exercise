using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise1;

namespace UnitTest
{
    [TestClass]
    public class GSMTest
    {
        private GSM testMyGSM = null;
        [TestInitialize]
        public void InitializedMyGSM()
        {
            testMyGSM = new GSM("Huawei P8", "Huawei", 254.00m, "Andrea <3", "HuaweiBattery", 9.0d, 5.0d, 5.1d, 16000000, BatteryType.LithiumIon);
            testMyGSM.AddNewCall("349-5695844", 120);
            testMyGSM.AddNewCall("346-5645566", 90);
            testMyGSM.AddNewCall("348-9658744", 30);
            testMyGSM.AddNewCall("336-9658742", 80);
            testMyGSM.AddNewCall("366-9675214", 80);
        }

        [TestMethod]
        public void TestGSM()
        {
            Assert.AreEqual("Huawei P8", testMyGSM.Model);
            Assert.AreEqual("Huawei", testMyGSM.Manufacturer);
            Assert.AreEqual(254.00m, testMyGSM.Price);
            Assert.AreEqual("Andrea <3", testMyGSM.Owner);
        }

        [TestMethod]
        public void TestBattery()
        {
            Battery myBatteryTest = new Battery("HuaweyBattery", 12.0d, 5.0d);
            string info = myBatteryTest.ToString();
            Assert.AreEqual("HuaweyBattery", myBatteryTest.Model);
            Assert.AreEqual(12.0d, myBatteryTest.IdleTime);
            Assert.AreEqual(5.0d, myBatteryTest.HoursTalk);
        }

        [TestMethod]
        public void TestDisplay()
        {
            Display myDisplayTest = new Display(5.1d, 16000000u);
            string info = myDisplayTest.ToString();
            Assert.AreEqual(5.1d, myDisplayTest.Size);
            Assert.AreEqual(16000000u, myDisplayTest.Colors);
        }

        [TestMethod]
        public void TestCallClass()
        {
            Call myCallTest = new Call("346-5968744", 80);
            string info = myCallTest.ToString();
            Assert.AreEqual("346-5968744", myCallTest.PhoneNumber);
            Assert.AreEqual(80, myCallTest.Duration);
        }

        [TestMethod]
        public void TestCountOfCall()
        {
            List<Call> listCalls = testMyGSM.MyCallHistory;
            Assert.AreEqual(5, listCalls.Count);
        }

        [TestMethod]
        public void TestAmouthOfCall()
        {
            decimal predictTotal = (0.37M * (120 + 90 + 80 + 80 + 30));
            Assert.AreEqual(predictTotal, testMyGSM.TotalAmouthCall(0.37M));
        }

        [TestMethod]
        public void TestAddCall()
        {
            testMyGSM.AddNewCall("345-9268322", 80);
            Assert.AreEqual(6, testMyGSM.MyCallHistory.Count);
        }

        [TestMethod]
        public void TestDeleteCall1()
        {
            testMyGSM.DeleteCalls(80);
            Assert.AreEqual(3, testMyGSM.MyCallHistory.Count);
        }

        [TestMethod]
        public void TestDeleteCall2()
        {
            testMyGSM.DeleteCalls("349-5695844");
            Assert.AreEqual(4, testMyGSM.MyCallHistory.Count);
        }

        [TestMethod]
        public void TestDeleteAllCalls()
        {
            testMyGSM.DeleteAllCall();
            Assert.AreEqual(0, testMyGSM.MyCallHistory.Count);
        }

        [TestMethod]
        public void TestStaticField()
        {
            Assert.AreEqual("Galaxy S7", GSM.samsungGalaxyS7.Model);
            Assert.AreEqual("Leo", GSM.samsungGalaxyS7.Owner);
            Assert.AreEqual(650M, GSM.samsungGalaxyS7.Price);
        }
    }
}
