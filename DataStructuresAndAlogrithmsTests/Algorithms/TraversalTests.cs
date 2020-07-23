using DataStructuresAndAlgorithms.Algorithms;
using DataStructuresAndAlgorithms.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DataStructuresAndAlogrithmsTests.Algorithms
{
    [TestClass]
    public class TraversalTests
    {
        [TestMethod]
        public void BreadthFirstSearch()
        {
            //Arrange

            var searcher = new Traversal();
            var expectedOutput = "9,4,20,1,6,15,170";

            var bst = new BinarySearchTree();
            bst.Insert(9);
            bst.Insert(4);
            bst.Insert(6);
            bst.Insert(20);
            bst.Insert(170);
            bst.Insert(15);
            bst.Insert(1);

            /*
                    9
                  /   \
                 4    20
                / \  /  \
               1  6 15  170
             */

            //Act - see Assert
            var output = searcher.BreadthFirstSearch(bst);

            //Assert
            Assert.AreEqual(expectedOutput, output);
            Assert.AreEqual(string.Empty, searcher.BreadthFirstSearch(null));
            Assert.AreEqual(string.Empty, searcher.BreadthFirstSearch(new BinarySearchTree()));
        }


        [TestMethod]
        public void BreadthFirstSearch_Recursive()
        {
            //Arrange

            var searcher = new Traversal();
            var expectedOutput = "9,4,20,1,6,15,170";

            var bst = new BinarySearchTree();
            bst.Insert(9);
            bst.Insert(4);
            bst.Insert(6);
            bst.Insert(20);
            bst.Insert(170);
            bst.Insert(15);
            bst.Insert(1);

            /*
                    9
                  /   \
                 4    20
                / \  /  \
               1  6 15  170
             */

            var queue = new Queue<BinarySearchTreeNode>();
            queue.Enqueue(bst.Root);
            var outputList = new List<string>();

            //Act - see Assert
            var output = searcher.BreadthFirstSearch_Recursive(queue, outputList);

            //Assert
            Assert.AreEqual(expectedOutput, output);
            Assert.AreEqual(string.Empty, searcher.BreadthFirstSearch_Recursive(null, new List<string>()));
            Assert.AreEqual(string.Empty, searcher.BreadthFirstSearch_Recursive(new Queue<BinarySearchTreeNode>(), new List<string>()));
        }

        [TestMethod]
        public void DepthFirstSearch_InOrder()
        {
            //Arrange

            var searcher = new Traversal();
            var expectedOutput = "1,4,6,9,15,20,170";

            var bst = new BinarySearchTree();
            bst.Insert(9);
            bst.Insert(4);
            bst.Insert(6);
            bst.Insert(20);
            bst.Insert(170);
            bst.Insert(15);
            bst.Insert(1);

            /*
                    9
                  /   \
                 4    20
                / \  /  \
               1  6 15  170
             */

            var outputList = new List<string>();

            //Act - see Assert
            var output = searcher.DepthFirstSearch_InOrder(bst.Root, outputList);

            //Assert
            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void DepthFirstSearch_PreOrder()
        {
            //Arrange

            var searcher = new Traversal();
            var expectedOutput = "9,4,1,6,20,15,170";

            var bst = new BinarySearchTree();
            bst.Insert(9);
            bst.Insert(4);
            bst.Insert(6);
            bst.Insert(20);
            bst.Insert(170);
            bst.Insert(15);
            bst.Insert(1);

            /*
                    9
                  /   \
                 4    20
                / \  /  \
               1  6 15  170
             */

            var outputList = new List<string>();

            //Act - see Assert
            var output = searcher.DepthFirstSearch_PreOrder(bst.Root, outputList);

            //Assert
            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void DepthFirstSearch_PostOrder()
        {
            //Arrange

            var searcher = new Traversal();
            var expectedOutput = "1,6,4,15,170,20,9";

            var bst = new BinarySearchTree();
            bst.Insert(9);
            bst.Insert(4);
            bst.Insert(6);
            bst.Insert(20);
            bst.Insert(170);
            bst.Insert(15);
            bst.Insert(1);

            /*
                    9
                  /   \
                 4    20
                / \  /  \
               1  6 15  170
             */

            var outputList = new List<string>();

            //Act - see Assert
            var output = searcher.DepthFirstSearch_PostOrder(bst.Root, outputList);

            //Assert
            Assert.AreEqual(expectedOutput, output);
        }
    }
}
