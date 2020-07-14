using DataStructuresAndAlgorithms.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresAndAlogrithmsTests.DataStructures
{
    [TestClass]
    public class GraphTests
    {
        /*
        Visualisation of the graph for these tests.
            
        3-------4-------5
        |       |       |
        |       |       |
        |       |       |
        1-------2       6
        \      /
          \   /
            0
             
        */

        private Graph graph;

        [TestInitialize]
        public void GraphTests_Setup()
        {
            this.graph = new Graph();

            this.graph.AddNode("0");
            this.graph.AddNode("1");
            this.graph.AddNode("2");
            this.graph.AddNode("3");
            this.graph.AddNode("4");
            this.graph.AddNode("5");
            this.graph.AddNode("6");
        }

        [TestMethod]
        public void GraphTests_AddNode()
        {
            // Arrange and Act
            // See initialisation

            // Assert
            Assert.AreEqual(7, this.graph.NumberOfNodes);
            Assert.IsTrue(this.graph.ContainsNode("0"));
            Assert.IsTrue(this.graph.ContainsNode("1"));
            Assert.IsTrue(this.graph.ContainsNode("2"));
            Assert.IsTrue(this.graph.ContainsNode("3"));
            Assert.IsTrue(this.graph.ContainsNode("4"));
            Assert.IsTrue(this.graph.ContainsNode("5"));
            Assert.IsTrue(this.graph.ContainsNode("6"));

            Assert.IsFalse(this.graph.ContainsNode("7"));
            Assert.IsFalse(this.graph.ContainsNode("8"));
            Assert.IsFalse(this.graph.ContainsNode("9"));
            Assert.IsFalse(this.graph.ContainsNode("A"));
            Assert.IsFalse(this.graph.ContainsNode("B"));
            Assert.IsFalse(this.graph.ContainsNode("C"));
        }

        [TestMethod]
        public void GraphTests_AddEdges()
        {
            // Arrange
            // See initialisation

            // Act
            this.graph.AddEdge("0", "1");
            this.graph.AddEdge("0", "2");
            this.graph.AddEdge("1", "2");
            this.graph.AddEdge("1", "3");
            this.graph.AddEdge("2", "4");
            this.graph.AddEdge("3", "4");
            this.graph.AddEdge("4", "5");
            this.graph.AddEdge("5", "6");

            // Assert
            Assert.AreEqual(7, this.graph.NumberOfNodes);

            Assert.AreEqual(2, this.graph.AdjacentList["0"].Count);
            Assert.AreEqual(3, this.graph.AdjacentList["1"].Count);
            Assert.AreEqual(3, this.graph.AdjacentList["2"].Count);
            Assert.AreEqual(2, this.graph.AdjacentList["3"].Count);
            Assert.AreEqual(3, this.graph.AdjacentList["4"].Count);
            Assert.AreEqual(2, this.graph.AdjacentList["5"].Count);
            Assert.AreEqual(1, this.graph.AdjacentList["6"].Count);

            Assert.IsTrue(this.graph.HasNeighbour("0", "1"));
            Assert.IsTrue(this.graph.HasNeighbour("0", "2"));
            Assert.IsTrue(this.graph.HasNeighbour("1", "0"));
            Assert.IsTrue(this.graph.HasNeighbour("1", "2"));
            Assert.IsTrue(this.graph.HasNeighbour("1", "3"));
            Assert.IsTrue(this.graph.HasNeighbour("2", "0"));
            Assert.IsTrue(this.graph.HasNeighbour("2", "1"));
            Assert.IsTrue(this.graph.HasNeighbour("2", "4"));
            Assert.IsTrue(this.graph.HasNeighbour("3", "1"));
            Assert.IsTrue(this.graph.HasNeighbour("3", "4"));
            Assert.IsTrue(this.graph.HasNeighbour("4", "2"));
            Assert.IsTrue(this.graph.HasNeighbour("4", "3"));
            Assert.IsTrue(this.graph.HasNeighbour("4", "5"));
            Assert.IsTrue(this.graph.HasNeighbour("5", "4"));
            Assert.IsTrue(this.graph.HasNeighbour("5", "6"));
            Assert.IsTrue(this.graph.HasNeighbour("6", "5"));

            Assert.IsFalse(this.graph.HasNeighbour("0", "6"));
            Assert.IsFalse(this.graph.HasNeighbour("6", "0"));
            Assert.IsFalse(this.graph.HasNeighbour("1", "6"));
            Assert.IsFalse(this.graph.HasNeighbour("6", "1"));
            Assert.IsFalse(this.graph.HasNeighbour("1", "4"));
            Assert.IsFalse(this.graph.HasNeighbour("4", "1"));
            Assert.IsFalse(this.graph.HasNeighbour("2", "5"));
            Assert.IsFalse(this.graph.HasNeighbour("5", "2"));
        }

        [TestMethod]
        public void GraphTests_RemoveEdge()
        {
            // Arrange
            // See initialisation

            // Act
            this.graph.AddEdge("0", "1");
            this.graph.AddEdge("0", "2");
            this.graph.AddEdge("1", "2");
            this.graph.AddEdge("1", "3");
            this.graph.AddEdge("2", "4");
            this.graph.AddEdge("3", "4");
            this.graph.AddEdge("4", "5");
            this.graph.AddEdge("5", "6");
            this.graph.RemoveEdge("5", "6");

            // Assert
            Assert.AreEqual(7, this.graph.NumberOfNodes);

            Assert.AreEqual(2, this.graph.AdjacentList["0"].Count);
            Assert.AreEqual(3, this.graph.AdjacentList["1"].Count);
            Assert.AreEqual(3, this.graph.AdjacentList["2"].Count);
            Assert.AreEqual(2, this.graph.AdjacentList["3"].Count);
            Assert.AreEqual(3, this.graph.AdjacentList["4"].Count);
            Assert.AreEqual(1, this.graph.AdjacentList["5"].Count);
            Assert.AreEqual(0, this.graph.AdjacentList["6"].Count);

            Assert.IsTrue(this.graph.HasNeighbour("0", "1"));
            Assert.IsTrue(this.graph.HasNeighbour("0", "2"));
            Assert.IsTrue(this.graph.HasNeighbour("1", "0"));
            Assert.IsTrue(this.graph.HasNeighbour("1", "2"));
            Assert.IsTrue(this.graph.HasNeighbour("1", "3"));
            Assert.IsTrue(this.graph.HasNeighbour("2", "0"));
            Assert.IsTrue(this.graph.HasNeighbour("2", "1"));
            Assert.IsTrue(this.graph.HasNeighbour("2", "4"));
            Assert.IsTrue(this.graph.HasNeighbour("3", "1"));
            Assert.IsTrue(this.graph.HasNeighbour("3", "4"));
            Assert.IsTrue(this.graph.HasNeighbour("4", "2"));
            Assert.IsTrue(this.graph.HasNeighbour("4", "3"));
            Assert.IsTrue(this.graph.HasNeighbour("4", "5"));
            Assert.IsTrue(this.graph.HasNeighbour("5", "4"));
            Assert.IsFalse(this.graph.HasNeighbour("5", "6"));
            Assert.IsFalse(this.graph.HasNeighbour("6", "5"));

            Assert.IsFalse(this.graph.HasNeighbour("0", "6"));
            Assert.IsFalse(this.graph.HasNeighbour("6", "0"));
            Assert.IsFalse(this.graph.HasNeighbour("1", "6"));
            Assert.IsFalse(this.graph.HasNeighbour("6", "1"));
            Assert.IsFalse(this.graph.HasNeighbour("1", "4"));
            Assert.IsFalse(this.graph.HasNeighbour("4", "1"));
            Assert.IsFalse(this.graph.HasNeighbour("2", "5"));
            Assert.IsFalse(this.graph.HasNeighbour("5", "2"));
        }

        [TestMethod]
        public void GraphTests_RemoveNode()
        {
            // Arrange
            // See initialisation

            // Act
            this.graph.AddEdge("0", "1");
            this.graph.AddEdge("0", "2");
            this.graph.AddEdge("1", "2");
            this.graph.AddEdge("1", "3");
            this.graph.AddEdge("2", "4");
            this.graph.AddEdge("3", "4");
            this.graph.AddEdge("4", "5");
            this.graph.AddEdge("5", "6");
            this.graph.RemoveNode("1");

            // Assert
            Assert.AreEqual(6, this.graph.NumberOfNodes);

            Assert.AreEqual(1, this.graph.AdjacentList["0"].Count);
            Assert.IsFalse(this.graph.ContainsNode("1"));
            Assert.AreEqual(2, this.graph.AdjacentList["2"].Count);
            Assert.AreEqual(1, this.graph.AdjacentList["3"].Count);
            Assert.AreEqual(3, this.graph.AdjacentList["4"].Count);
            Assert.AreEqual(2, this.graph.AdjacentList["5"].Count);
            Assert.AreEqual(1, this.graph.AdjacentList["6"].Count);

            Assert.IsFalse(this.graph.HasNeighbour("0", "1"));
            Assert.IsTrue(this.graph.HasNeighbour("0", "2"));
            Assert.IsFalse(this.graph.HasNeighbour("1", "0"));
            Assert.IsFalse(this.graph.HasNeighbour("1", "2"));
            Assert.IsFalse(this.graph.HasNeighbour("1", "3"));
            Assert.IsTrue(this.graph.HasNeighbour("2", "0"));
            Assert.IsFalse(this.graph.HasNeighbour("2", "1"));
            Assert.IsTrue(this.graph.HasNeighbour("2", "4"));
            Assert.IsFalse(this.graph.HasNeighbour("3", "1"));
            Assert.IsTrue(this.graph.HasNeighbour("3", "4"));
            Assert.IsTrue(this.graph.HasNeighbour("4", "2"));
            Assert.IsTrue(this.graph.HasNeighbour("4", "3"));
            Assert.IsTrue(this.graph.HasNeighbour("4", "5"));
            Assert.IsTrue(this.graph.HasNeighbour("5", "4"));
            Assert.IsTrue(this.graph.HasNeighbour("5", "6"));
            Assert.IsTrue(this.graph.HasNeighbour("6", "5"));

            Assert.IsFalse(this.graph.HasNeighbour("0", "6"));
            Assert.IsFalse(this.graph.HasNeighbour("6", "0"));
            Assert.IsFalse(this.graph.HasNeighbour("1", "6"));
            Assert.IsFalse(this.graph.HasNeighbour("6", "1"));
            Assert.IsFalse(this.graph.HasNeighbour("1", "4"));
            Assert.IsFalse(this.graph.HasNeighbour("4", "1"));
            Assert.IsFalse(this.graph.HasNeighbour("2", "5"));
            Assert.IsFalse(this.graph.HasNeighbour("5", "2"));
        }
    }
}
