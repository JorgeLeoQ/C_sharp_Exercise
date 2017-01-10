using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise6;

namespace UnitTestProject1
{
    [TestClass]
    public class Test6
    {
        [TestMethod]
        [ExpectedException(typeof(FileParseException))]
        public void TestFileParseErrorRead()
        {
            string path = @"..\..\TestErrorRead.txt";
            TryFileParser.TryParse(path);
        }

        [TestMethod]
        [ExpectedException(typeof(FileParseException))]
        public void TestFileParseErrorOpen()
        {
            string path = @"..\..\TestErrorOpen.txt";
            TryFileParser.TryParse(path);
        }

        [TestMethod]
        public void TestFileRightParse()
        {
            string path = @"..\..\TestOk.txt";
            TryFileParser.TryParse(path);
        }

        [TestMethod]
        public void TestWithoutNothingToRead()
        {
            string path = @"..\..\TestEmpty.txt";
            TryFileParser.TryParse(path);
        }
    }
}
