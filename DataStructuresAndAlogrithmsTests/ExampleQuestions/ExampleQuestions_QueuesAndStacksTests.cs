using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DataStructuresAndAlgorithms.ExampleQuestions.ExampleQuestions_QueuesAndStacks;

namespace DataStructuresAndAlogrithmsTests.ExampleQuestions
{
    [TestClass]
    public class ExampleQuestions_QueuesAndStacksTests
    {
        [TestMethod]
        public void StackBasedQueueTests_Enqueue()
        {
            //Arrange

            var queue = new StackBasedQueue();

            //Act
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            //Assert
            Assert.IsFalse(queue.IsEmpty());
            Assert.AreEqual(1, queue.Peek());
        }

        [TestMethod]
        public void StackBasedQueueTests_Dequeue()
        {
            //Arrange
            var queue = new StackBasedQueue();

            //Act
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            var output = queue.Dequeue();

            //Assert
            Assert.IsFalse(queue.IsEmpty());
            Assert.AreEqual(1, output);
        }

        [TestMethod]
        public void StackBasedQueueTests_Peek()
        {
            //Arrange
            var queue = new StackBasedQueue();

            //Act
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            var output = queue.Peek();

            //Assert
            Assert.IsFalse(queue.IsEmpty());
            Assert.AreEqual(1, output);
        }

        [TestMethod]
        public void StackBasedQueueTests_Empty()
        {
            //Arrange
            var queue = new StackBasedQueue();

            //Act
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            //Assert
            Assert.IsTrue(queue.IsEmpty());
        }
    }
}
