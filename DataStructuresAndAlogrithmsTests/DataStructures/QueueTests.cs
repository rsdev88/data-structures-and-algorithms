using DataStructuresAndAlgorithms.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DataStructuresAndAlogrithmsTests.DataStructures
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void QueueTests_Enqueue()
        {
            //Arrange

            var queue = new Queue(1);

            //Act
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            //Assert
            Assert.IsFalse(queue.IsEmpty);
            Assert.AreEqual(5, queue.Length);
            Assert.AreEqual(1, queue.Head.Value);
            Assert.AreEqual(5, queue.Tail.Value);
        }

        [TestMethod]
        public void QueueTests_Dequeue()
        {
            //Arrange
            var queue = new Queue(1);

            //Act
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            var output = queue.Dequeue();

            //Assert
            Assert.IsFalse(queue.IsEmpty);
            Assert.AreEqual(4, queue.Length);
            Assert.AreEqual(2, queue.Head.Value);
            Assert.AreEqual(5, queue.Tail.Value);
            Assert.AreEqual(1, output);
        }

        [TestMethod]
        public void QueueTests_Peek()
        {
            //Arrange
            var queue = new Queue(1);

            //Act
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            var output = queue.Peek();

            //Assert
            Assert.IsFalse(queue.IsEmpty);
            Assert.AreEqual(5, queue.Length);
            Assert.AreEqual(1, output);
        }

        [TestMethod]
        public void QueueTests_Empty()
        {
            //Arrange
            var queue = new Queue(1);

            //Act
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            //Assert
            Assert.IsTrue(queue.IsEmpty);
            Assert.AreEqual(0, queue.Length);
        }
    }
}
