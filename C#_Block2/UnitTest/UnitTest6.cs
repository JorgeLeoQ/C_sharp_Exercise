using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise6;

namespace UnitTest
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void TestDecimalToBinary()
        {
            int decimalValue = 125;
            Assert.AreEqual("1111101", ConvertNotation.DecimalToBinary(decimalValue), "Error in Decimal to Binary method");
        }

        [TestMethod]
        public void TestBinaryToDecimal()
        {
            string binaryValue = "1111101";
            Assert.AreEqual(125, ConvertNotation.BinaryToDecimal(binaryValue), "Error in binary todecimal method");
        }

        [TestMethod]
        public void TestHexToDecimal()
        {
            string hexValue = "7D";
            Assert.AreEqual(125, ConvertNotation.HexToDecimal(hexValue), "Error in hexadecimal to decimal method");
        }
    }
}
