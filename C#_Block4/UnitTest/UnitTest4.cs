using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise4;

namespace UnitTest
{
    [TestClass]
    public class UnitTest4
    {
        DoubleLinkedList<string> myDoubleLinkList = new DoubleLinkedList<string>();
         
        [TestInitialize]
        public void InitializzeList()
        {
            myDoubleLinkList.AddNode("Papà", 1);
            myDoubleLinkList.AddNode("Mamma", 3);
            myDoubleLinkList.AddNode("Figlio", 5);
            myDoubleLinkList.AddNode("Figlia", 7);
            myDoubleLinkList.AddNode("Cane", 9);
        }

        [TestMethod]
        public void TestSorceWithIndex()
        {
            string result = myDoubleLinkList.Search(9);
            Assert.AreEqual("Cane", result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestDeleteNodeEx()
        {
            myDoubleLinkList.DeleteNode(4);
        }

        [TestMethod]
        public void TestGetList()
        {
            string[] myList = myDoubleLinkList.GetList();
            string[] result = new string[] { "Papà", "Mamma", "Figlio", "Figlia", "Cane" };
            CollectionAssert.AreEqual(result, myList);
        }

        [TestMethod]
        public void TestSearchIndex()
        {
            string result = myDoubleLinkList.Search(3);
            Assert.AreEqual("Mamma", result);
        }

        [TestMethod]
        public void TestAddNode()
        {
            myDoubleLinkList.AddNode("Ciao", 0);
            myDoubleLinkList.AddNode("Hola", 2);
            myDoubleLinkList.AddNode("Hi", 10);
            string[] result = new string[] {"Ciao", "Papà", "Hola", "Mamma", "Figlio", "Figlia", "Cane" , "Hi"};
            CollectionAssert.AreEqual(result, myDoubleLinkList.GetList());
        }

        [TestMethod]
        public void TestDeleteNode()
        {
            myDoubleLinkList.DeleteNode(1);
            myDoubleLinkList.DeleteNode(5);
            string[] expected = new string[] { "Mamma", "Figlia", "Cane" };
            string[] result = myDoubleLinkList.GetList();
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
