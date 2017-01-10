using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise7;

namespace UnitTestProject1
{
    [TestClass]
    public class Test7
    {
        public string webUrl = "http://1.bp.blogspot.com/-2qXU_Bec_I4/VCz51kxslII/AAAAAAAAAk0/poEWi0KeLTQ/s1600/csharp.png";
        public string webUrl1 = "http://www.ionosodovefiniremo.org/image.jpg";

        [TestMethod]
        public void Test()
        {
            DownloadFile.Download(webUrl);
            Assert.IsTrue(File.Exists("csharp.png"));
        }

        [TestMethod]
        [ExpectedException(typeof(DownloadFromInternetException))]
        public void Test2()
        {
            DownloadFile.Download(webUrl1);
        }
    }
}
