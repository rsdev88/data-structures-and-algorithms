using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.DataStructures
{
    //An undirected unweighted graph built using an adjacent list with an underlying hash table.
    public class Graph
    {
        public int NumberOfNodes { get; set; }
        public Dictionary<string, List<string>> AdjacentList { get; set; }

        public Graph()
        {
            this.NumberOfNodes = 0;
            this.AdjacentList = new Dictionary<string, List<string>>();
        }

        public void AddNode(string nodeValue)
        {
            this.AdjacentList.Add(nodeValue, new List<string>());
            this.NumberOfNodes++;
        }

        public void AddEdge(string node1, string node2)
        {
            this.AdjacentList[node1].Add(node2);
            this.AdjacentList[node2].Add(node1);
        }

        public void RemoveEdge(string node1, string node2)
        {
            this.AdjacentList[node1].Remove(node2);
            this.AdjacentList[node2].Remove(node1);
        }

        public void RemoveNode(string nodeValue)
        {
            //Remove any edges between the node that's being removed and its neighbours.
            var nodeNeigbours = this.AdjacentList[nodeValue];
            if (nodeNeigbours != null && nodeNeigbours.Count > 0)
            {
                foreach (string neighbour in nodeNeigbours)
                {
                    this.AdjacentList[neighbour].Remove(nodeValue);
                }
            }

            //Remove the node itself
            this.AdjacentList.Remove(nodeValue);
            this.NumberOfNodes--;
        }

        public bool ContainsNode(string nodeValue)
        {
            return this.AdjacentList.ContainsKey(nodeValue);
        }

        public bool HasNeighbour(string node, string neighbour)
        {
            return this.AdjacentList.ContainsKey(node) && this.AdjacentList[node].Contains(neighbour);
        }
    }
}
