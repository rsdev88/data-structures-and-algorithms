using DataStructuresAndAlgorithms.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlogrithmsTests.DataStructures
{
    [TestClass]
    public class BinarySearchTreeTests
    {
        [TestMethod]
        public void BinarySearchTreeTests_InsertIntoEmptyTree()
        {
            //Arrange
            var tree = new BinarySearchTree();

            //Act
            tree.Insert(9);

            //Assert
            Assert.AreEqual(1, tree.Length);
            Assert.AreEqual(9, tree.Root.Value);
            Assert.IsNull(tree.Root.LeftChild);
            Assert.IsNull(tree.Root.RightChild);
        }

        [TestMethod]
        public void BinarySearchTreeTests_Insert()
        {
            //Arrange
            var tree = new BinarySearchTree();

            //Act
            tree.Insert(9);
            tree.Insert(4);
            tree.Insert(6);
            tree.Insert(20);
            tree.Insert(170);
            tree.Insert(15);
            tree.Insert(1);

            //Assert
            Assert.AreEqual(7, tree.Length);
            Assert.AreEqual(9, tree.Root.Value);
            Assert.AreEqual(4, tree.Root.LeftChild.Value);
            Assert.AreEqual(20, tree.Root.RightChild.Value);
        }

        [TestMethod]
        public void BinarySearchTreeTests_Lookup_PositiveResult()
        {
            //Arrange
            var tree = new BinarySearchTree();
            BinarySearchTreeNode expectedOutput = new BinarySearchTreeNode()
            {
                Value = 20,
                LeftChild = new BinarySearchTreeNode() { Value = 15 },
                RightChild = new BinarySearchTreeNode() { Value = 170 }
            };

            tree.Insert(9);
            tree.Insert(4);
            tree.Insert(6);
            tree.Insert(20);
            tree.Insert(170);
            tree.Insert(15);
            tree.Insert(1);

            //Act
            var output = tree.Lookup(20);

            //Assert
            Assert.AreEqual(7, tree.Length);
            Assert.IsTrue(expectedOutput.Equals(output));
        }

        [TestMethod]
        public void BinarySearchTreeTests_Lookup_NegativeResult()
        {
            //Arrange
            var tree = new BinarySearchTree();

            tree.Insert(9);
            tree.Insert(4);
            tree.Insert(6);
            tree.Insert(20);
            tree.Insert(170);
            tree.Insert(15);
            tree.Insert(1);

            //Act
            var output = tree.Lookup(21);

            //Assert
            Assert.AreEqual(7, tree.Length);
            Assert.IsNull(output);
        }
    }
}
