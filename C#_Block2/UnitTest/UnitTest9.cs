using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise9;

namespace UnitTest
{
    [TestClass]
    public class UnitTest9
    {
        [TestMethod]
        public void TestFindSequenceMaxPosition()
        {
            int maxLength;
            int position;
            int[] arrayTest = new int[] {3,5,1,2};
            arrayTest = MaximalSeqIncreElement.FindSequence(arrayTest, out maxLength, out position);
            Assert.AreEqual(arrayTest[position], arrayTest[1]);
        }
        [TestMethod]
        public void TestFindMaxLength()
        {
            int maxLenght;
            int position;
            int[] arrayTest = new int[] { 3, 5, 1, 2 };
            arrayTest = MaximalSeqIncreElement.FindSequence(arrayTest, out maxLenght, out position);
            Assert.AreEqual(maxLenght, arrayTest.Length);
        }
        [TestMethod]
        public void TestFindSequenceExample()
        {
            int maxLength;
            int position;
            int[] arrayExample = new int[] { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };
            int[] arrayMaxSeqExample = new int[] { 2, 4, 5, 8 };
            int[] arrayElab =MaximalSeqIncreElement.FindSequence(arrayExample, out maxLength, out position);
            CollectionAssert.AreEqual(arrayMaxSeqExample, arrayElab);
        }
    }
}
