using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {

        [TestMethod]
        public void TestDies()
        {
            Die[] dieArray0 = new Die[10];
            Die[] dieArray1 = new Die[10];
            for(int i = 0; i < dieArray0.Length; i++ )
            {
                dieArray0[i] = new Die();
                dieArray1[i] = new Die();
            }

            Array.Sort(dieArray0);
            Array.Sort(dieArray1);

            for(int i = 0; i < dieArray0.Length; i++)
            {
                if(dieArray0[i] == dieArray1[i])
                {
                    Assert.AreEqual(dieArray0[i], dieArray1[i]);
                }
                else
                {
                    Assert.AreNotEqual(dieArray0[i], dieArray1[i]);
                }
            }
        }
    }
}
