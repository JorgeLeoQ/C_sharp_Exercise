using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise4;

namespace UnitTest
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestZeroString()
        {
            string number = "Zero";
            Assert.AreEqual(number, ConvertString.ConvtDigitToString(0), "Error while convert in string.");
        }

        [TestMethod]
        public void TestUnitString()
        {
            string number = "five";
            Assert.AreEqual(number, ConvertString.ConvtDigitToString(5), "Error while convert in string.");
        }

        [TestMethod]
        public void TestDozensString()
        {
            string number = "twelve";
            Assert.AreEqual(number, ConvertString.ConvtDigitToString(12), "Error while convert in string.");
            number = "ninety eight";
            Assert.AreEqual(number, ConvertString.ConvtDigitToString(98), "Error while convert in string.");
        }

        [TestMethod]
        public void TestHundredsString()
        {
            string number = "Two hundred seventy three";
            Assert.AreEqual(number, ConvertString.ConvtDigitToString(273), "Error while convert in string.");
            number = "Seven hundred and eleven";
            Assert.AreEqual(number, ConvertString.ConvtDigitToString(711), "Error while convert in string.");
        }
    }
}
