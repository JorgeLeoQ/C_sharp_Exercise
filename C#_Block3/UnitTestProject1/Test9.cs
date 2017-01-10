using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise9;

namespace UnitTestProject1
{
    [TestClass]
    public class Test9
    {
        [TestMethod]
        public void TestMailExtract()
        {
            string lineString = @"Please contact us by phone (+001 222 222 222) or by email at example@gmail.com or at test.user@yahoo.co.uk. This is not email: test@test. This also: @gmail.com. Neither this: a@a.b.";
            Assert.AreEqual("example@gmail.com\r\ntest.user@yahoo.co.uk\r\n", EmailExtract.ExtractEmails(lineString));
        }
    }
}
