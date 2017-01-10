using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise7;

namespace UnitTest
{
    [TestClass]
    public class UnitTest7
    {
        bool isArrayCompete(int[] randomArray)
        {
            bool[] checkArrayComplete = new bool[randomArray.Length];
            foreach (int i in randomArray)
            {
                checkArrayComplete[i - 1] = true;
            }
            foreach (bool b in checkArrayComplete)
            {
                if (!b)
                    return false;
            }
            return true;
        }
        bool isArrayRandom(int[] randomArray)
        {
            int diffSum = 0;
            for (int i = 0; i < randomArray.Length - 1; i++)
            {
                diffSum += Math.Abs(randomArray[i + 1] - randomArray[i]);
            }
            if (diffSum == randomArray.Length)
                return false;
            return true;
        }

        [TestMethod]
        public void TestRandomArrayTen()
        {
            int n = 10;
            Assert.IsTrue(isArrayRandom(RandomArray.Randomizer(n)));
        }
        [TestMethod]
        public void TestRandomArrayHundred()
        {
            int n = 100;
            Assert.IsTrue(isArrayRandom(RandomArray.Randomizer(n)));
        }
        [TestMethod]
        public void TestRandomArrayTenThousands()
        {
            int n = 10000;
            Assert.IsTrue(isArrayRandom(RandomArray.Randomizer(n)));
        }

        [TestMethod]
        public void TestCompleteArrayTen()
        {
            int n = 10;
            Assert.IsTrue(isArrayCompete(RandomArray.Randomizer(n)));
        }
        [TestMethod]
        public void TestCompleteArrayHundred()
        {
            int n = 100;
            Assert.IsTrue(isArrayCompete(RandomArray.Randomizer(n)));
        }
        [TestMethod]
        public void TestCompleteArrayTenThousands()
        {
            int n = 10000;
            Assert.IsTrue(isArrayCompete(RandomArray.Randomizer(n)));
        }
        [TestMethod]
        public void TestCallTwoTimeRandomArray()
        {
            int[] arrayOne = RandomArray.Randomizer(5);
            int[] arrayTwo = RandomArray.Randomizer(5);
            CollectionAssert.AreNotEqual(arrayOne, arrayTwo);
        }
    }
}
