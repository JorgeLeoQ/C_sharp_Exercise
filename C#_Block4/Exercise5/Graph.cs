using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise5
{
    public class GraphConnections
    {
        List<int>[] childNodes;
        public GraphConnections(List<int>[] childNodes)
        {
            this.childNodes = childNodes;
        }

        public int NodesNumber
        {
            get { return childNodes.Length; }
        }

        public List<SortedSet<int>> SearchSubgraphs()
        {
            List<SortedSet<int>> subgraphs = new List<SortedSet<int>>();
            bool[] nodes = new bool[childNodes.Length];
            for (int index = 0; index < childNodes.Length; index++)
            {
                if (!nodes[index])
                {
                    subgraphs.Add(new SortedSet<int>());
                    RecursiveSubgraphNodes(nodes, subgraphs[subgraphs.Count - 1], index);
                }
            }
            return subgraphs;
        }

        public void RecursiveSubgraphNodes(bool[] counted, SortedSet<int> currentSubgraph, int nodeNumber)
        {
            counted[nodeNumber] = true;
            currentSubgraph.Add(nodeNumber);
            if (childNodes[nodeNumber] != null)
                foreach (var childNode in childNodes[nodeNumber])
                {
                    if (!counted[childNode])
                    {
                        RecursiveSubgraphNodes(counted, currentSubgraph, childNode);
                    }
                }
        }
    }
}