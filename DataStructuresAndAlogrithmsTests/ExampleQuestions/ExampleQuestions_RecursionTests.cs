using DataStructuresAndAlgorithms.ExampleQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresAndAlogrithmsTests.ExampleQuestions
{
    [TestClass]
    public class ExampleQuestions_RecursionTests
    {
        [TestMethod]
        public void FindFactorial_Recursion()
        {
            //Arrange
            var tester = new ExampleQuestions_Recursion();

            //Act - see assertions

            //Assert
            Assert.AreEqual(0, tester.FindFactorialRecursive(0));
            Assert.AreEqual(1, tester.FindFactorialRecursive(1));
            Assert.AreEqual(2, tester.FindFactorialRecursive(2));
            Assert.AreEqual(6, tester.FindFactorialRecursive(3));
            Assert.AreEqual(24, tester.FindFactorialRecursive(4));
            Assert.AreEqual(120, tester.FindFactorialRecursive(5));
            Assert.AreEqual(720, tester.FindFactorialRecursive(6));
            Assert.AreEqual(5040, tester.FindFactorialRecursive(7));
            Assert.AreEqual(40320, tester.FindFactorialRecursive(8));
            Assert.AreEqual(362880, tester.FindFactorialRecursive(9));
            Assert.AreEqual(3628800, tester.FindFactorialRecursive(10));
        }

        [TestMethod]
        public void FindFactorial_Iterative()
        {
            //Arrange
            var tester = new ExampleQuestions_Recursion();

            //Act - see assertions

            //Assert
            Assert.AreEqual(0, tester.FindFactorialIterative(0));
            Assert.AreEqual(1, tester.FindFactorialIterative(1));
            Assert.AreEqual(2, tester.FindFactorialIterative(2));
            Assert.AreEqual(6, tester.FindFactorialIterative(3));
            Assert.AreEqual(24, tester.FindFactorialIterative(4));
            Assert.AreEqual(120, tester.FindFactorialIterative(5));
            Assert.AreEqual(720, tester.FindFactorialIterative(6));
            Assert.AreEqual(5040, tester.FindFactorialIterative(7));
            Assert.AreEqual(40320, tester.FindFactorialIterative(8));
            Assert.AreEqual(362880, tester.FindFactorialIterative(9));
            Assert.AreEqual(3628800, tester.FindFactorialIterative(10));
        }

        [TestMethod]
        public void Fibonacci_Recursive()
        {
            //Arrange 
            var tester = new ExampleQuestions_Recursion();

            //Act - see assertions

            //Assert
            Assert.AreEqual(0, tester.Fibonacci_Recursive(0));
            Assert.AreEqual(1, tester.Fibonacci_Recursive(1));
            Assert.AreEqual(1, tester.Fibonacci_Recursive(2));
            Assert.AreEqual(2, tester.Fibonacci_Recursive(3));
            Assert.AreEqual(3, tester.Fibonacci_Recursive(4));
            Assert.AreEqual(5, tester.Fibonacci_Recursive(5));
            Assert.AreEqual(8, tester.Fibonacci_Recursive(6));
            Assert.AreEqual(13, tester.Fibonacci_Recursive(7));
            Assert.AreEqual(21, tester.Fibonacci_Recursive(8));
            Assert.AreEqual(34, tester.Fibonacci_Recursive(9));
            Assert.AreEqual(55, tester.Fibonacci_Recursive(10));
            Assert.AreEqual(89, tester.Fibonacci_Recursive(11));
            Assert.AreEqual(144, tester.Fibonacci_Recursive(12));
        }

        [TestMethod]
        public void Fibonacci_Iterative()
        {
            //Arrange 
            var tester = new ExampleQuestions_Recursion();

            //Act - see assertions

            //Assert
            Assert.AreEqual(0, tester.Fibonacci_Recursive(0));
            Assert.AreEqual(1, tester.Fibonacci_Recursive(1));
            Assert.AreEqual(1, tester.Fibonacci_Recursive(2));
            Assert.AreEqual(2, tester.Fibonacci_Recursive(3));
            Assert.AreEqual(3, tester.Fibonacci_Recursive(4));
            Assert.AreEqual(5, tester.Fibonacci_Recursive(5));
            Assert.AreEqual(8, tester.Fibonacci_Recursive(6));
            Assert.AreEqual(13, tester.Fibonacci_Recursive(7));
            Assert.AreEqual(21, tester.Fibonacci_Recursive(8));
            Assert.AreEqual(34, tester.Fibonacci_Recursive(9));
            Assert.AreEqual(55, tester.Fibonacci_Recursive(10));
            Assert.AreEqual(89, tester.Fibonacci_Recursive(11));
            Assert.AreEqual(144, tester.Fibonacci_Recursive(12));
        }

        [TestMethod]
        public void ReverseString_Recursive()
        {
            //Arrange 
            var tester = new ExampleQuestions_Recursion();

            //Act - see assertions

            Assert.AreEqual("!dlrow olleH", tester.ReverseString("Hello world!"));
            Assert.AreEqual("serutcurts ataD", tester.ReverseString("Data structures"));
            Assert.AreEqual("smhtiroglA", tester.ReverseString("Algorithms"));
            Assert.AreEqual("god yzal eht revo spmuj xof nworb kciuq ehT", tester.ReverseString("The quick brown fox jumps over the lazy dog"));
        }
    }
}
