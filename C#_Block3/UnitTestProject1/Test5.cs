using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise5;

namespace UnitTestProject1
{
    [TestClass]
    public class Test5
    {
        [TestMethod]
        public void Test1000RandomString()
        {
            for (int i = 1; i <= 1000; i++)
            {
                int[] randomIndex1 = MessageGenerator.GetArrayIndexRandom();
                int[] randomIndex2 = MessageGenerator.GetArrayIndexRandom();
                string message1 = MessageGenerator.CreateMesssage(randomIndex1);
                string message2 = MessageGenerator.CreateMesssage(randomIndex2);
                StringAssert.Equals(message1, message2);
            }
        }

        private bool FindAnyString(String msg, String[] stringArray, out int findIndex)
        {
            findIndex = -1;
            for (int j = 0; j < stringArray.Length; j++)
            {
                int i = msg.IndexOf(stringArray[j]);
                if (i != -1)
                {
                    findIndex = j;
                    return true;
                }
            }
            return false;
        }

        [TestMethod]
        public void TestRandomMessageWithString()
        {
            int[] randomIndex = MessageGenerator.GetArrayIndexRandom();
            string message = MessageGenerator.CreateMesssage(randomIndex);
            int findIndex = 0;
            Assert.IsTrue(FindAnyString(message, MessageGenerator.phrase, out findIndex));
            Assert.IsTrue(FindAnyString(message, MessageGenerator.story, out findIndex));
            Assert.IsTrue(FindAnyString(message, MessageGenerator.city, out findIndex));
            Assert.IsTrue(FindAnyString(message, MessageGenerator.firstName, out findIndex));
            Assert.IsTrue(FindAnyString(message, MessageGenerator.lastName, out findIndex));
        }

        [TestMethod]
        public void TestRandomMessage_StringRandom()
        {
            int[] randomIndex1 = MessageGenerator.GetArrayIndexRandom();
            int[] randomIndex2 = MessageGenerator.GetArrayIndexRandom();
            String msg1 = MessageGenerator.CreateMesssage(randomIndex1);
            String msg2 = MessageGenerator.CreateMesssage(randomIndex2);
            int findIndex1 = 0;
            int findIndex2 = 0;
            FindAnyString(msg1, MessageGenerator.phrase, out findIndex1);
            FindAnyString(msg2, MessageGenerator.phrase, out findIndex2);
            int praisingPhrasesDiff = Math.Abs(findIndex1 - findIndex2);

            FindAnyString(msg1, MessageGenerator.story, out findIndex1);
            FindAnyString(msg2, MessageGenerator.story, out findIndex2);
            int praisingEventsDiff = Math.Abs(findIndex1 - findIndex2);

            FindAnyString(msg1, MessageGenerator.city, out findIndex1);
            FindAnyString(msg2, MessageGenerator.city, out findIndex2);
            int authorsCityDiff = Math.Abs(findIndex1 - findIndex2);

            FindAnyString(msg1, MessageGenerator.firstName, out findIndex1);
            FindAnyString(msg2, MessageGenerator.firstName, out findIndex2);
            int authorsFirstNameDiff = Math.Abs(findIndex1 - findIndex2);

            FindAnyString(msg1, MessageGenerator.lastName, out findIndex1);
            FindAnyString(msg2, MessageGenerator.lastName, out findIndex2);
            int authorsLastNameDiff = Math.Abs(findIndex1 - findIndex2);

            Assert.AreNotSame(0, praisingPhrasesDiff + praisingEventsDiff + authorsCityDiff + authorsFirstNameDiff + authorsLastNameDiff);
        }
    }
}
