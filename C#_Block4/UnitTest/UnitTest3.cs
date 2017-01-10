using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise3;

namespace UnitTest
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestOpenFileXML()
        {
            ExtractXmlFIle xmlFile = new ExtractXmlFIle();
            string expected = "Peter\r\n21\r\nGames\r\nC#\r\nJava\r\n";
            Assert.AreEqual(expected, xmlFile.ReadXMLFile(@"..\..\MyText.xml"));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestNotXMLFile()
        {
            ExtractXmlFIle xmlFile = new ExtractXmlFIle();
            string stringFile = xmlFile.ReadXMLFile(@"wrongFile.txt");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestFineNotFound()
        {
            ExtractXmlFIle xmlFile = new ExtractXmlFIle();
            string stringFile = xmlFile.ReadXMLFile(@"..\..\notFoundText.xml");
        }
    }
}
