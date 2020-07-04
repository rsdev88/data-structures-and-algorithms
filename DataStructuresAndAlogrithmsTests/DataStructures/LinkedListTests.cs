using DataStructuresAndAlgorithms.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresAndAlogrithmsTests.DataStructures
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void LinkedListTests_Prepend()
        {
            // Arrange
            var linkedList = new LinkedList(5);

            //Act
            linkedList.Prepend(4);
            linkedList.Prepend(3);
            linkedList.Prepend(2);

            //Assert
            Assert.AreEqual(4, linkedList.Length);
            Assert.AreEqual(2, linkedList.Head.Value);
            Assert.AreEqual(3, linkedList.Head.Next.Value);
            Assert.AreEqual(4, linkedList.Head.Next.Next.Value);
            Assert.AreEqual(5, linkedList.Head.Next.Next.Next.Value);
            Assert.AreEqual(5, linkedList.Tail.Value);
        }

        [TestMethod]
        public void LinkedListTests_Append()
        {
            // Arrange
            var linkedList = new LinkedList(5);

            //Act
            linkedList.Append(4);
            linkedList.Append(3);
            linkedList.Append(2);

            //Assert
            Assert.AreEqual(4, linkedList.Length);
            Assert.AreEqual(5, linkedList.Head.Value);
            Assert.AreEqual(4, linkedList.Head.Next.Value);
            Assert.AreEqual(3, linkedList.Head.Next.Next.Value);
            Assert.AreEqual(2, linkedList.Head.Next.Next.Next.Value);
            Assert.AreEqual(2, linkedList.Tail.Value);
        }

        [TestMethod]
        public void LinkedListTests_DeleteFromStart()
        {
            // Arrange
            var linkedList = new LinkedList(5);

            //Act
            linkedList.Append(4);
            linkedList.Append(3);
            linkedList.Append(2);
            linkedList.DeleteFromStart();

            //Assert
            Assert.AreEqual(3, linkedList.Length);
            Assert.AreEqual(4, linkedList.Head.Value);
            Assert.AreEqual(3, linkedList.Head.Next.Value);
            Assert.AreEqual(2, linkedList.Head.Next.Next.Value);
            Assert.AreEqual(2, linkedList.Tail.Value);
        }

        [TestMethod]
        public void LinkedListTests_DeleteFromStart_OneItemList()
        {
            // Arrange
            var linkedList = new LinkedList(5);

            //Act
            linkedList.DeleteFromStart();

            //Assert
            Assert.AreEqual(0, linkedList.Length);
            Assert.AreEqual(null, linkedList.Head);
            Assert.AreEqual(null, linkedList.Tail);
        }

        [TestMethod]
        public void LinkedListTests_DeleteFromEnd()
        {
            // Arrange
            var linkedList = new LinkedList(5);

            //Act
            linkedList.Append(4);
            linkedList.Append(3);
            linkedList.Append(2);
            linkedList.DeleteFromEnd();

            //Assert
            Assert.AreEqual(3, linkedList.Length);
            Assert.AreEqual(5, linkedList.Head.Value);
            Assert.AreEqual(4, linkedList.Head.Next.Value);
            Assert.AreEqual(3, linkedList.Head.Next.Next.Value);
            Assert.AreEqual(3, linkedList.Tail.Value);
        }

        [TestMethod]
        public void LinkedListTests_DeleteFromEnd_OneItemList()
        {
            // Arrange
            var linkedList = new LinkedList(5);

            //Act
            linkedList.DeleteFromEnd();

            //Assert
            Assert.AreEqual(0, linkedList.Length);
            Assert.AreEqual(null, linkedList.Head);
            Assert.AreEqual(null, linkedList.Tail);
        }

        [TestMethod]
        public void LinkedListTests_Insert()
        {
            // Arrange
            var linkedList = new LinkedList(5);

            //Act
            linkedList.Append(4);
            linkedList.Append(3);
            linkedList.Append(1);
            linkedList.Insert(4, 2);

            //Assert
            Assert.AreEqual(5, linkedList.Length);
            Assert.AreEqual(5, linkedList.Head.Value);
            Assert.AreEqual(4, linkedList.Head.Next.Value);
            Assert.AreEqual(3, linkedList.Head.Next.Next.Value);
            Assert.AreEqual(2, linkedList.Head.Next.Next.Next.Value);
            Assert.AreEqual(1, linkedList.Head.Next.Next.Next.Next.Value);
            Assert.AreEqual(1, linkedList.Tail.Value);
        }

        [TestMethod]
        public void LinkedListTests_InsertAtZero()
        {
            // Arrange
            var linkedList = new LinkedList(5);

            //Act
            linkedList.Append(4);
            linkedList.Append(3);
            linkedList.Append(2);
            linkedList.Insert(0, 6);

            //Assert
            Assert.AreEqual(5, linkedList.Length);
            Assert.AreEqual(6, linkedList.Head.Value);
            Assert.AreEqual(5, linkedList.Head.Next.Value);
            Assert.AreEqual(4, linkedList.Head.Next.Next.Value);
            Assert.AreEqual(3, linkedList.Head.Next.Next.Next.Value);
            Assert.AreEqual(2, linkedList.Head.Next.Next.Next.Next.Value);
            Assert.AreEqual(2, linkedList.Tail.Value);
        }

        [TestMethod]
        public void LinkedListTests_Insert_InvalidIndex()
        {
            // Arrange
            var linkedList = new LinkedList(5);

            //Act
            linkedList.Append(4);
            linkedList.Append(3);
            linkedList.Append(1);
            linkedList.Insert(7, 2);

            //Assert
            Assert.AreEqual(4, linkedList.Length);
            Assert.AreEqual(5, linkedList.Head.Value);
            Assert.AreEqual(4, linkedList.Head.Next.Value);
            Assert.AreEqual(3, linkedList.Head.Next.Next.Value);
            Assert.AreEqual(1, linkedList.Head.Next.Next.Next.Value);
            Assert.AreEqual(1, linkedList.Tail.Value);
        }

        [TestMethod]
        public void LinkedListTests_Delete()
        {
            // Arrange
            var linkedList = new LinkedList(5);

            //Act
            linkedList.Append(4);
            linkedList.Append(3);
            linkedList.Append(3);
            linkedList.Append(2);
            linkedList.Delete(4);

            //Assert
            Assert.AreEqual(4, linkedList.Length);
            Assert.AreEqual(5, linkedList.Head.Value);
            Assert.AreEqual(4, linkedList.Head.Next.Value);
            Assert.AreEqual(3, linkedList.Head.Next.Next.Value);
            Assert.AreEqual(2, linkedList.Head.Next.Next.Next.Value);
            Assert.AreEqual(2, linkedList.Tail.Value);
        }

        [TestMethod]
        public void LinkedListTests_DeleteAtZero()
        {
            // Arrange
            var linkedList = new LinkedList(5);

            //Act
            linkedList.Append(4);
            linkedList.Append(3);
            linkedList.Append(2);
            linkedList.Append(1);
            linkedList.Delete(0);

            //Assert
            Assert.AreEqual(4, linkedList.Length);
            Assert.AreEqual(4, linkedList.Head.Value);
            Assert.AreEqual(3, linkedList.Head.Next.Value);
            Assert.AreEqual(2, linkedList.Head.Next.Next.Value);
            Assert.AreEqual(1, linkedList.Head.Next.Next.Next.Value);
            Assert.AreEqual(1, linkedList.Tail.Value);
        }

        [TestMethod]
        public void LinkedListTests_Delete_InvalidIndex()
        {
            // Arrange
            var linkedList = new LinkedList(5);

            //Act
            linkedList.Append(4);
            linkedList.Append(3);
            linkedList.Append(3);
            linkedList.Append(2);
            linkedList.Delete(7);

            //Assert
            Assert.AreEqual(5, linkedList.Length);
            Assert.AreEqual(5, linkedList.Head.Value);
            Assert.AreEqual(4, linkedList.Head.Next.Value);
            Assert.AreEqual(3, linkedList.Head.Next.Next.Value);
            Assert.AreEqual(3, linkedList.Head.Next.Next.Next.Value);
            Assert.AreEqual(2, linkedList.Head.Next.Next.Next.Next.Value);
            Assert.AreEqual(2, linkedList.Tail.Value);
        }
    }
}
