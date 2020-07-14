using DataStructuresAndAlgorithms.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresAndAlogrithmsTests.DataStructures
{
    [TestClass]
    public class DoublyLinkedListsTests
    {
        [TestMethod]
        public void DoublyLinkedListTests_Prepend()
        {
            // Arrange
            var linkedList = new DoublyLinkedList(5);

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
            Assert.IsNull(linkedList.Head.Next.Next.Next.Next);

            Assert.AreEqual(5, linkedList.Tail.Value);
            Assert.AreEqual(4, linkedList.Tail.Previous.Value);
            Assert.AreEqual(3, linkedList.Tail.Previous.Previous.Value);
            Assert.AreEqual(2, linkedList.Tail.Previous.Previous.Previous.Value);
            Assert.IsNull(linkedList.Tail.Previous.Previous.Previous.Previous);
        }

        [TestMethod]
        public void DoublyLinkedListTests_Append()
        {
            // Arrange
            var linkedList = new DoublyLinkedList(5);

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
            Assert.IsNull(linkedList.Head.Next.Next.Next.Next);

            Assert.AreEqual(2, linkedList.Tail.Value);
            Assert.AreEqual(3, linkedList.Tail.Previous.Value);
            Assert.AreEqual(4, linkedList.Tail.Previous.Previous.Value);
            Assert.AreEqual(5, linkedList.Tail.Previous.Previous.Previous.Value);
            Assert.IsNull(linkedList.Tail.Previous.Previous.Previous.Previous);
        }

        [TestMethod]
        public void DoublyLinkedListTests_DeleteFromStart()
        {
            // Arrange
            var linkedList = new DoublyLinkedList(5);

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
            Assert.IsNull(linkedList.Head.Next.Next.Next);

            Assert.AreEqual(2, linkedList.Tail.Value);
            Assert.AreEqual(3, linkedList.Tail.Previous.Value);
            Assert.AreEqual(4, linkedList.Tail.Previous.Previous.Value);
            Assert.IsNull(linkedList.Tail.Previous.Previous.Previous);
        }

        [TestMethod]
        public void DoublyLinkedListTests_DeleteFromStart_OneItemList()
        {
            // Arrange
            var linkedList = new DoublyLinkedList(5);

            //Act
            linkedList.DeleteFromStart();

            //Assert
            Assert.AreEqual(0, linkedList.Length);
            Assert.AreEqual(null, linkedList.Head);
            Assert.AreEqual(null, linkedList.Tail);
        }

        [TestMethod]
        public void DoublyLinkedListTests_DeleteFromEnd()
        {
            // Arrange
            var linkedList = new DoublyLinkedList(5);

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
            Assert.IsNull(linkedList.Head.Next.Next.Next);

            Assert.AreEqual(3, linkedList.Tail.Value);
            Assert.AreEqual(4, linkedList.Tail.Previous.Value);
            Assert.AreEqual(5, linkedList.Tail.Previous.Previous.Value);
            Assert.IsNull(linkedList.Tail.Previous.Previous.Previous);
        }

        [TestMethod]
        public void DoublyLinkedListTests_DeleteFromEnd_OneItemList()
        {
            // Arrange
            var linkedList = new DoublyLinkedList(5);

            //Act
            linkedList.DeleteFromEnd();

            //Assert
            Assert.AreEqual(0, linkedList.Length);
            Assert.AreEqual(null, linkedList.Head);
            Assert.AreEqual(null, linkedList.Tail);
        }

        [TestMethod]
        public void DoublyLinkedListTests_Insert_FirstHalf()
        {
            // Arrange
            var linkedList = new DoublyLinkedList(5);

            //Act
            linkedList.Append(3);
            linkedList.Append(2);
            linkedList.Append(1);
            linkedList.Insert(2, 4);

            //Assert
            Assert.AreEqual(5, linkedList.Length);

            Assert.AreEqual(5, linkedList.Head.Value);
            Assert.AreEqual(4, linkedList.Head.Next.Value);
            Assert.AreEqual(3, linkedList.Head.Next.Next.Value);
            Assert.AreEqual(2, linkedList.Head.Next.Next.Next.Value);
            Assert.AreEqual(1, linkedList.Head.Next.Next.Next.Next.Value);
            Assert.IsNull(linkedList.Head.Next.Next.Next.Next.Next);

            Assert.AreEqual(1, linkedList.Tail.Value);
            Assert.AreEqual(2, linkedList.Tail.Previous.Value);
            Assert.AreEqual(3, linkedList.Tail.Previous.Previous.Value);
            Assert.AreEqual(4, linkedList.Tail.Previous.Previous.Previous.Value);
            Assert.AreEqual(5, linkedList.Tail.Previous.Previous.Previous.Previous.Value);
            Assert.IsNull(linkedList.Tail.Previous.Previous.Previous.Previous.Previous);
        }

        [TestMethod]
        public void DoublyLinkedListTests_Insert_SecondHalf()
        {
            // Arrange
            var linkedList = new DoublyLinkedList(6);

            //Act
            linkedList.Append(5);
            linkedList.Append(4);
            linkedList.Append(3);
            linkedList.Append(1);
            linkedList.Insert(5, 2);

            //Assert
            Assert.AreEqual(6, linkedList.Length);

            Assert.AreEqual(6, linkedList.Head.Value);
            Assert.AreEqual(5, linkedList.Head.Next.Value);
            Assert.AreEqual(4, linkedList.Head.Next.Next.Value);
            Assert.AreEqual(3, linkedList.Head.Next.Next.Next.Value);
            Assert.AreEqual(2, linkedList.Head.Next.Next.Next.Next.Value);
            Assert.AreEqual(1, linkedList.Head.Next.Next.Next.Next.Next.Value);
            Assert.IsNull(linkedList.Head.Next.Next.Next.Next.Next.Next);

            Assert.AreEqual(1, linkedList.Tail.Value);
            Assert.AreEqual(2, linkedList.Tail.Previous.Value);
            Assert.AreEqual(3, linkedList.Tail.Previous.Previous.Value);
            Assert.AreEqual(4, linkedList.Tail.Previous.Previous.Previous.Value);
            Assert.AreEqual(5, linkedList.Tail.Previous.Previous.Previous.Previous.Value);
            Assert.AreEqual(6, linkedList.Tail.Previous.Previous.Previous.Previous.Previous.Value);
            Assert.IsNull(linkedList.Tail.Previous.Previous.Previous.Previous.Previous.Previous);
        }

        [TestMethod]
        public void DoublyLinkedListTests_Delete_FirstHalf()
        {
            // Arrange
            var linkedList = new DoublyLinkedList(5);

            //Act
            linkedList.Append(4);
            linkedList.Append(3);
            linkedList.Append(3);
            linkedList.Append(2);
            linkedList.Append(1);
            linkedList.Delete(3);

            //Assert
            Assert.AreEqual(5, linkedList.Length);

            Assert.AreEqual(5, linkedList.Head.Value);
            Assert.AreEqual(4, linkedList.Head.Next.Value);
            Assert.AreEqual(3, linkedList.Head.Next.Next.Value);
            Assert.AreEqual(2, linkedList.Head.Next.Next.Next.Value);
            Assert.AreEqual(1, linkedList.Head.Next.Next.Next.Next.Value);
            Assert.IsNull(linkedList.Head.Next.Next.Next.Next.Next);

            Assert.AreEqual(1, linkedList.Tail.Value);
            Assert.AreEqual(2, linkedList.Tail.Previous.Value);
            Assert.AreEqual(3, linkedList.Tail.Previous.Previous.Value);
            Assert.AreEqual(4, linkedList.Tail.Previous.Previous.Previous.Value);
            Assert.AreEqual(5, linkedList.Tail.Previous.Previous.Previous.Previous.Value);
            Assert.IsNull(linkedList.Tail.Previous.Previous.Previous.Previous.Previous);
        }

        [TestMethod]
        public void DoublyLinkedListTests_Delete_SecondHalf()
        {
            // Arrange
            var linkedList = new DoublyLinkedList(5);

            //Act
            linkedList.Append(4);
            linkedList.Append(3);
            linkedList.Append(3);
            linkedList.Append(2);
            linkedList.Append(1);
            linkedList.Delete(4);

            //Assert
            Assert.AreEqual(5, linkedList.Length);

            Assert.AreEqual(5, linkedList.Head.Value);
            Assert.AreEqual(4, linkedList.Head.Next.Value);
            Assert.AreEqual(3, linkedList.Head.Next.Next.Value);
            Assert.AreEqual(2, linkedList.Head.Next.Next.Next.Value);
            Assert.AreEqual(1, linkedList.Head.Next.Next.Next.Next.Value);
            Assert.IsNull(linkedList.Head.Next.Next.Next.Next.Next);

            Assert.AreEqual(1, linkedList.Tail.Value);
            Assert.AreEqual(2, linkedList.Tail.Previous.Value);
            Assert.AreEqual(3, linkedList.Tail.Previous.Previous.Value);
            Assert.AreEqual(4, linkedList.Tail.Previous.Previous.Previous.Value);
            Assert.AreEqual(5, linkedList.Tail.Previous.Previous.Previous.Previous.Value);
            Assert.IsNull(linkedList.Tail.Previous.Previous.Previous.Previous.Previous);
        }
    }
}
