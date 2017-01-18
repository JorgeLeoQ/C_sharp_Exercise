using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wather;

namespace TestWeater
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSensorValueArray()
        {
            Direction vers = Direction.E;
            State stable = State.stable;
            Pressure sensorPress = new Pressure(20, "FSAw", stable);
            Wind sensorWind = new Wind(10, "ATX", vers);
            Sensor sensorA = new Sensor(230, "sss");
            Sensor[] sensors = new Sensor[] { sensorA, sensorWind };
            Assert.AreEqual(230, sensors[0].Value);
            Assert.AreEqual(10, sensors[1].Value);
            Assert.AreEqual("ATX", sensors[1].Model);
        }
    }
}
