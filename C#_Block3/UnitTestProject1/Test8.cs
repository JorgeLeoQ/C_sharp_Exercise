using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise8;

namespace UnitTestProject1
{
    [TestClass]
    public class Test8
    {
        [TestMethod]
        public void TestExampleEncrypts()
        {
            string StringInput = "Test";
            string cipher = "ab";
            string result = "\\u0035\\u0007\\u0012\\u0016";
            Assert.AreEqual(result, EncryptsText.Crypt(StringInput, cipher));
        }

        [TestMethod]
        public void TestEncryptsNumber()
        {
            string result = "\\u0050\\u0050\\u0052\\u0056\\u0054\\u0054\\u0056\\u005a\\u0058";
            string StringInput = "123456789";
            string cipher = "ab";
            Assert.AreEqual(result, EncryptsText.Crypt(StringInput, cipher));
        }

        [TestMethod]
        public void TestEncryptsWithBlank()
        {
            string result = "\\u0029\\u000b\\u0041\\u000f\\u0018\\u0042\\u000f\\u0003\\u000c\\u0007\\u0041\\u000b\\u0012\\u0042\\u002c\\u0003\\u0013\\u000b\\u000e\\u0042\\u0033\\u000d\\u0012\\u0011\\u0008";
            string StringInput = "Hi my name is Mario Rossi";
            string cipher = "ab";
            Assert.AreEqual(result, EncryptsText.Crypt(StringInput, cipher));
        }

        [TestMethod]
        public void TestWithSameCipher1()
        {
            string result = "\\u0000\\u0000\\u0000\\u0000\\u0000\\u0000\\u0000\\u0000";
            string StringInput = "abcdefgh";
            string cipher = "abcdefgh";
            Assert.AreEqual(result, EncryptsText.Crypt(StringInput, cipher));
        }

        [TestMethod]
        public void TestWithSameCipher2()
        {
            string result = "\\u0000\\u0000\\u0000\\u0000\\u0000\\u0000\\u0000\\u0000\\u0000";
            string stringInput = "123456789";
            string cipher = "123456789";
            Assert.AreEqual(result, EncryptsText.Crypt(stringInput, cipher));
        }

        [TestMethod]
        public void TestComplexString()
        {
            string result = "\\u007f\\u0057\\u005f\\u0014\\u0058\\u0053\\u004d\\u0042\\u0056\\u0011\\u0056\\u0056\\u0058\\u0015\\u0055\\u0056\\u0055\\u0054\\u0058\\u005c\\u0013\\u0050\\u005c\\u0016\\u0059\\u0057\\u004a\\u0045\\u0040\\u0052\\u0014\\u0043\\u005f\\u0043\\u0059\\u0019\\u005c\\u005b\\u0013\\u0046\\u005c\\u0042\\u0045\\u0057\\u004f\\u0050\\u005b\\u0013\\u0044\\u0050\\u0044\\u0017\\u004d\\u0057\\u0050\\u0012\\u0040\\u0051\\u0059\\u0040\\u0056\\u0018\\u0056\\u0042\\u0051\\u0046\\u0046\\u0054\\u0016\\u0054\\u0050\\u00d0\\u0011\\u005e\\u0052\\u0014\\u0051\\u005f\\u0045\\u0051\\u004d\\u0045\\u0053\\u0013\\u0042\\u005c\\u0057\\u0017\\u005d\\u004b\\u0050\\u0012\\u0040\\u0059\\u0054\\u0044\\u0045\\u0051\\u004d\\u0050";
            string stringInput = "Nel mezzo del cammin di nostra vita mi ritrovai per una selva oscura ché la diritta via era smarrita";
            string cipher = "123456789";
            Assert.AreEqual(result, EncryptsText.Crypt(stringInput, cipher));
        }
    }
}
