using DataStructuresAndAlgorithms.DataStructures;
using DataStructuresAndAlgorithms.ExampleQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresAndAlogrithmsTests.ExampleQuestions
{
    [TestClass]
    public class ExampleQuestions_TraversalsTests
    {
        [TestMethod]
        public void ValidateBinarySearchTree_ValidTree()
        {
            //Arrange

            var searcher = new ExampleQuestions_Traversals();

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
            var output = searcher.ValidateBinaryTree(bst);

            //Assert
            Assert.IsTrue(output);
        }

        [TestMethod]
        public void ValidateBinarySearchTree_SingleItemTree()
        {
            //Arrange

            var searcher = new ExampleQuestions_Traversals();

            var bst = new BinarySearchTree();
            bst.Insert(9);

            //Act - see Assert
            var output = searcher.ValidateBinaryTree(bst);

            //Assert
            Assert.IsTrue(output);
        }

        [TestMethod]
        public void ValidateBinarySearchTree_NullInput()
        {
            //Arrange

            var searcher = new ExampleQuestions_Traversals();

            //Act - see Assert
            var output = searcher.ValidateBinaryTree(null);

            //Assert
            Assert.IsFalse(output);
        }

        [TestMethod]
        public void ValidateBinarySearchTree_InvalidLeftChild()
        {
            //Arrange

            var searcher = new ExampleQuestions_Traversals();

            var bst = new BinarySearchTree();
            bst.Insert(9);
            bst.Insert(4);
            bst.Insert(6);
            bst.Insert(20);
            bst.Insert(170);
            bst.Insert(15);
            bst.Insert(1);

            //Directly update a node to create an invalid tree
            bst.Root.LeftChild.Value = 10;

            /*
                    9
                  /   \
                10    20
                / \  /  \
               1  6 15  170
             */

            //Act - see Assert
            var output = searcher.ValidateBinaryTree(bst);

            //Assert
            Assert.IsFalse(output);
        }

        [TestMethod]
        public void ValidateBinarySearchTree_InvalidRightChild()
        {
            //Arrange

            var searcher = new ExampleQuestions_Traversals();

            var bst = new BinarySearchTree();
            bst.Insert(9);
            bst.Insert(4);
            bst.Insert(6);
            bst.Insert(20);
            bst.Insert(170);
            bst.Insert(15);
            bst.Insert(1);

            //Directly update a node to create an invalid tree
            bst.Root.RightChild.Value = 2;

            /*
                    9
                  /   \
                 4     2
                / \  /  \
               1  6 15  170
             */

            //Act - see Assert
            var output = searcher.ValidateBinaryTree(bst);

            //Assert
            Assert.IsFalse(output);
        }
    }
}
