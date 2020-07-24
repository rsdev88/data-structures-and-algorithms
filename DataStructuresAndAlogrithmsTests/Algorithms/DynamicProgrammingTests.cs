using DataStructuresAndAlgorithms.Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresAndAlogrithmsTests.Algorithms
{
    [TestClass]
    public class DynamicProgrammingTests
    {
        [TestMethod]
        public void MemoizedFibonacci_Tests()
        {
            //Arrange 
            var tester = new DynamicProgramming();

            //Act - see assertions

            //Assert
            Assert.AreEqual(0, tester.Memoized_Fibonacci(0));
            Assert.AreEqual(1, tester.Memoized_Fibonacci(1));
            Assert.AreEqual(1, tester.Memoized_Fibonacci(2));
            Assert.AreEqual(2, tester.Memoized_Fibonacci(3));
            Assert.AreEqual(3, tester.Memoized_Fibonacci(4));
            Assert.AreEqual(5, tester.Memoized_Fibonacci(5));
            Assert.AreEqual(8, tester.Memoized_Fibonacci(6));
            Assert.AreEqual(13, tester.Memoized_Fibonacci(7));
            Assert.AreEqual(21, tester.Memoized_Fibonacci(8));
            Assert.AreEqual(34, tester.Memoized_Fibonacci(9));
            Assert.AreEqual(55, tester.Memoized_Fibonacci(10));
            Assert.AreEqual(89, tester.Memoized_Fibonacci(11));
            Assert.AreEqual(144, tester.Memoized_Fibonacci(12));
        }

    }
}
