using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise10;

namespace UnitTest
{
    [TestClass]
    public class UnitTest10
    {

        [TestMethod]
        public void TestAMatrixWhit4x4()
        {
          int length=4;
          int[,] arrayTrue = new int[4,4] { {1,5,9,13}, { 2, 6, 10, 14 }, { 3, 7, 11, 15}, { 4, 8, 12,16} };
          int[,] arrayTest = Matrix.AMatrix(length);
          CollectionAssert.AreEqual(arrayTest, arrayTrue);
        }
        [TestMethod]
        public void TestBMatrixWhit4x4()
        {
            int length = 4;
            int[,] arrayTrue = new int[4, 4] { { 1, 8, 9, 16 }, { 2, 7, 10, 15 }, { 3, 6, 11, 14 }, { 4, 5, 12, 13 } };
            int[,] arrayTest = Matrix.BMatrix(length);
            CollectionAssert.AreEqual(arrayTest, arrayTrue);
        }
        [TestMethod]
        public void TestCMatrixWhit4x4()
        {
            int length = 4;
            int[,] arrayTrue = new int[4, 4] { { 7, 11, 14, 16 }, { 4, 8, 12, 15 }, { 2, 5, 9, 13 }, { 1, 3, 6, 10 } };
            int[,] arrayTest = Matrix.CMatrix(length);
            CollectionAssert.AreEqual(arrayTest, arrayTrue);
        }
        [TestMethod]
        public void TestDMatrixWhit4x4()
        {
            int length = 4;
            int[,] arrayTrue = new int[4, 4] { { 1, 12, 11, 10 }, { 2, 13, 16, 9 }, { 3, 14, 15, 8 }, { 4, 5, 6, 7} };
            int[,] arrayTest = Matrix.DMatrix(length);
            CollectionAssert.AreEqual(arrayTest, arrayTrue);
        }
    }
}
