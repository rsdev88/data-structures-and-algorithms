using DataStructuresAndAlgorithms.Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace DataStructuresAndAlogrithmsTests.Algorithms
{
    [TestClass]
    public class SortingTests
    {
        [TestMethod]
        public void BubbleSort()
        {
            //Arrange
            var sorter = new Sorting();
            var unsortedList = new List<int>() { 5, 1, 9, 2, 7, 2, 1, 0, 32, 4 };
            var expectedOutput = new List<int>() { 0, 1, 1, 2, 2, 4, 5, 7, 9, 32 };

            //Act
            var output = sorter.BubbleSort(unsortedList);

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual(expectedOutput, output));
        }

        [TestMethod]
        public void SelectionSort()
        {
            //Arrange
            var sorter = new Sorting();
            var unsortedList = new List<int>() { 5, 1, 9, 2, 7, 2, 1, 0, 32, 4 };
            var expectedOutput = new List<int>() { 0, 1, 1, 2, 2, 4, 5, 7, 9, 32 };

            //Act
            var output = sorter.SelectionSort(unsortedList);

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual(expectedOutput, output));
        }

        [TestMethod]
        public void InsertionSort()
        {
            //Arrange
            var sorter = new Sorting();
            var unsortedList = new List<int>() { 5, 1, 9, 2, 7, 2, 1, 0, 32, 4 };
            var expectedOutput = new List<int>() { 0, 1, 1, 2, 2, 4, 5, 7, 9, 32 };

            //Act
            var output = sorter.InsertionSort(unsortedList);

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual(expectedOutput, output));
        }

        [TestMethod]
        public void MergeSort()
        {
            //Arrange
            var sorter = new Sorting();
            var unsortedList = new List<int>() { 5, 1, 9, 2, 7, 2, 1, 0, 32, 4 };
            var expectedOutput = new List<int>() { 0, 1, 1, 2, 2, 4, 5, 7, 9, 32 };

            //Act
            var output = sorter.MergeSort(unsortedList);

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual(expectedOutput, output));
        }

        [TestMethod]
        public void QuickSort()
        {
            //Arrange
            var sorter = new Sorting();
            var unsortedList = new List<int>() { 5, 1, 9, 2, 7, 2, 1, 0, 32, 4 };
            var expectedOutput = new List<int>() { 0, 1, 1, 2, 2, 4, 5, 7, 9, 32 };

            //Act
            var output = sorter.QuickSort(unsortedList, 0, unsortedList.Count - 1);

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual(expectedOutput, output));
        }
    }
}
