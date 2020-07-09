using DataStructuresAndAlgorithms.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresAndAlogrithmsTests.DataStructures
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void StackTests_Push()
        {
            //Arrange
            var stack = new Stack(1);

            //Act
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            //Assert
            Assert.IsFalse(stack.IsEmpty);
            Assert.AreEqual(5, stack.Length);
            Assert.AreEqual(5, stack.Head.Value);
        }

        [TestMethod]
        public void StackTests_Pop()
        {
            //Arrange
            var stack = new Stack(1);

            //Act
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            var output = stack.Pop();

            //Assert
            Assert.IsFalse(stack.IsEmpty);
            Assert.AreEqual(4, stack.Length);
            Assert.AreEqual(4, stack.Head.Value);
            Assert.AreEqual(5, output);
        }

        [TestMethod]
        public void StackTests_Peek()
        {
            //Arrange
            var stack = new Stack(1);

            //Act
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            var output = stack.Peek();

            //Assert
            Assert.IsFalse(stack.IsEmpty);
            Assert.AreEqual(5, stack.Length);
            Assert.AreEqual(5, output);
        }

        [TestMethod]
        public void StackTests_Empty()
        {
            //Arrange
            var stack = new Stack(1);

            //Act
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            stack.Pop();
            stack.Pop();

            //Assert
            Assert.IsTrue(stack.IsEmpty);
            Assert.AreEqual(0, stack.Length);
        }
    }
}
