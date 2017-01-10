using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Exercise5;

namespace ClassTest
{
    [TestClass]
    public class UnitTest05
    {
        [TestMethod]
        public void TestGraphOneDimensional()
        {
            List<int>[] values = new List<int>[3];
            values[0] = new List<int> { 2 };
            values[1] = new List<int> { 1 };
            values[2] = new List<int> { 0 };
            GraphConnections graph = new GraphConnections(values);
            List<SortedSet<int>> subgraph = graph.SearchSubgraphs();
            Assert.AreEqual(2, subgraph.Count);
            SortedSet<int> expected0 = new SortedSet<int> { 0, 2 };
            SortedSet<int> expected1 = new SortedSet<int> { 1 };
            CollectionAssert.AreEqual(expected0, subgraph[0]);
            CollectionAssert.AreEqual(expected1, subgraph[1]);
        }

        [TestMethod]
        public void TestGraphThreeDimensional()
        {
            List<int>[] values = new List<int>[9];
            values[0] = new List<int> { 0, 1 };
            values[1] = new List<int> { 2 };
            values[2] = new List<int> { 3 };
            values[4] = new List<int> { 5 };
            values[7] = new List<int> { 8 };
            GraphConnections graph = new GraphConnections(values);
            List<SortedSet<int>> subgraph = graph.SearchSubgraphs();
            Assert.AreEqual(4, subgraph.Count);
            SortedSet<int> expected0 = new SortedSet<int> { 0, 1, 2, 3 };
            SortedSet<int> expected1 = new SortedSet<int> { 4, 5 };
            SortedSet<int> expected2 = new SortedSet<int> { 7, 8 };
            CollectionAssert.AreEqual(expected0, subgraph[0]);
            CollectionAssert.AreEqual(expected1, subgraph[1]);
            CollectionAssert.AreEqual(expected2, subgraph[3]);
        }
    }
}