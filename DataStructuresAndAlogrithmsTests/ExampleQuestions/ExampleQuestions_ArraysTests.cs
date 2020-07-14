using DataStructuresAndAlgorithms.ExampleQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace DataStructuresAndAlogrithmsTests.ExampleQuestions
{
    [TestClass]
    public class ExampleQuestions_ArraysTests
    {
        ExampleQuestions_Arrays processor;

        [TestInitialize]
        public void ExampleQuestionsTests()
        {
            this.processor = new ExampleQuestions_Arrays();
        }

        [TestMethod]
        public void ReversedStringTests()
        {
            //Arrange
            var input = "Hi, my name is Rob";
            var expectedOutput = "boR si eman ym ,iH";

            //Act
            var output = this.processor.ReverseAString(input);

            //Assert
            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void MergedArraysBruteForceTests()
        {
            //Arrange
            var array1 = new int[] { 0, 3, 4, 31 };
            var array2 = new int[] { 4, 5, 30 };
            var expectedOutput = new int[] { 0, 3, 4, 4, 5, 30, 31 };

            //Act
            var output = this.processor.MergeSortedArrays_BruteForce(array1, array2);

            //Assert
            Assert.IsTrue(output.SequenceEqual(expectedOutput));
        }

        [TestMethod]
        public void MergedArraysOofNTests()
        {
            //Arrange
            var array1 = new int[] { 0, 3, 4, 31 };
            var array2 = new int[] { 4, 5, 30 };
            var expectedOutput = new int[] { 0, 3, 4, 4, 5, 30, 31 };

            //Act
            var output = this.processor.MergeSortedArrays_OofNSolution(array1, array2);

            //Assert
            Assert.IsTrue(output.SequenceEqual(expectedOutput));
        }

        [TestMethod]
        public void MergedArraysOofNTests_BiggerSecondArray()
        {
            //Arrange
            var array1 = new int[] { 0, 3, 4, 31 };
            var array2 = new int[] { 4, 5, 30, 30, 31 };
            var expectedOutput = new int[] { 0, 3, 4, 4, 5, 30, 30, 31, 31 };

            //Act
            var output = this.processor.MergeSortedArrays_OofNSolution(array1, array2);

            //Assert
            Assert.IsTrue(output.SequenceEqual(expectedOutput));
        }
    }
}
