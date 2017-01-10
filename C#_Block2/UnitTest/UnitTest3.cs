using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise3;

namespace UnitTest
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestRealRoots()
        {
            int aNumber = 1;
            int bNumber = 2;
            int cNumber = -15;
            float[] result = QuadraticEquation.quadraticEquation(aNumber, bNumber, cNumber);
            float[] arrayTrue = new float[2] { 3, -5 };
            CollectionAssert.AreEqual(result, arrayTrue);
            bNumber = 0;
            cNumber = -4;
            result = QuadraticEquation.quadraticEquation(aNumber, bNumber, cNumber);
            arrayTrue[0] = 2;
            arrayTrue[1] = -2;
            CollectionAssert.AreEqual(result, arrayTrue);
        }

        [TestMethod]
        public void TestCoincidentRoots()
        {
            int aNumber = 1;
            int bNumber = -4;
            int cNumber = 4;
            float[] result = QuadraticEquation.quadraticEquation(aNumber, bNumber, cNumber);
            float[] arrayTrue = new float[2] { 2, 2 };
            CollectionAssert.AreEqual(result, arrayTrue);
            bNumber = 0;
            cNumber = 0;
            result = QuadraticEquation.quadraticEquation(aNumber, bNumber, cNumber);
            arrayTrue[0] = arrayTrue[1] = 0;
            CollectionAssert.AreEqual(result, arrayTrue);
        }

        [TestMethod]
        public void TestNegativeDelta()
        {
            int aNumber = 1;
            int bNumber = 1;
            int cNumber = 1;
            float[] result = QuadraticEquation.quadraticEquation(aNumber, bNumber, cNumber);
            float[] arrayTrue = new float[2] { 0, 0 };
            CollectionAssert.AreEqual(result, arrayTrue);
        }
    }
}
