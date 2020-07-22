using DataStructuresAndAlgorithms.Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DataStructuresAndAlogrithmsTests.Algorithms
{
    [TestClass]
    public class SearchingTests
    {

        [TestMethod]
        public void LinearSearch()
        {
            //Arrange
            var list = new List<string>()
            {
                "pepperoni",
                "margherita",
                "hawaiian",
                "diavola",
                "funghi",
                "meat feast"
            };
            var searcher = new Searching<string>();

            //Act - see Assert

            //Assert
            Assert.AreEqual(0, searcher.LinearSearch(list, "pepperoni"));
            Assert.AreEqual(1, searcher.LinearSearch(list, "margherita"));
            Assert.AreEqual(2, searcher.LinearSearch(list, "hawaiian"));
            Assert.AreEqual(3, searcher.LinearSearch(list, "diavola"));
            Assert.AreEqual(4, searcher.LinearSearch(list, "funghi"));
            Assert.AreEqual(5, searcher.LinearSearch(list, "meat feast"));
            Assert.IsNull(searcher.LinearSearch(list, "BBQ chicken"));
            Assert.IsNull(searcher.LinearSearch(list, "farmhouse"));
            Assert.IsNull(searcher.LinearSearch(null, "pepperoni"));
            Assert.IsNull(searcher.LinearSearch(new List<string>(), "pepperoni"));
        }

        [TestMethod]
        public void BinarySearch()
        {
            //Arrange
            var list = new List<int>()
            {
                1, 4, 6, 9, 12, 34
            };
            var searcher = new Searching<int>();

            //Act - see Assert

            //Assert
            Assert.IsTrue(searcher.BinarySearch(list, 1));
            Assert.IsTrue(searcher.BinarySearch(list, 4));
            Assert.IsTrue(searcher.BinarySearch(list, 6));
            Assert.IsTrue(searcher.BinarySearch(list, 9));
            Assert.IsTrue(searcher.BinarySearch(list, 12));
            Assert.IsTrue(searcher.BinarySearch(list, 34));
            Assert.IsFalse(searcher.BinarySearch(list, 0));
            Assert.IsFalse(searcher.BinarySearch(list, 2));
            Assert.IsFalse(searcher.BinarySearch(null, 34));
            Assert.IsFalse(searcher.BinarySearch(new List<int>(), 34));
        }
    }
}
