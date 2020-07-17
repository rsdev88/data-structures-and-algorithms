
using DataStructuresAndAlgorithms.Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresAndAlogrithmsTests.Algorithms
{
    [TestClass]
    public class RecursionTests
    {
        [TestMethod]
        public void BasicRecursion_Tests()
        {
            //Arrange
            var tester = new Recursion();

            //Act
            var output = tester.Inception();

            //Assert
            Assert.AreEqual("Done!", output);
        }
    }
}
