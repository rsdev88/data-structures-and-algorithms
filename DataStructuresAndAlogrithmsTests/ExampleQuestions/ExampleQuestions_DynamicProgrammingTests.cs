using DataStructuresAndAlgorithms.ExampleQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresAndAlogrithmsTests.ExampleQuestions
{
    [TestClass]
    public class ExampleQuestions_DynamicProgrammingTests
    {
        [TestMethod]
        [DataRow(new int[4] { 1,2,3,1 }, 4)]
        [DataRow(new int[5] { 2,7,9,3,1 }, 12)]
        [DataRow(new int[4] { 2,1,1,2 }, 4)]
        [DataRow(new int[0] { }, 0)]
        [DataRow(null, 0)]
        [DataRow(new int[1] {9}, 9)]
        public void HouseRobbing(int[] input, int expectedOutput)
        {
            //Arrange
            var tester = new ExampleQuestions_DynamicProgramming();

            //Act
            var output = tester.RobHouse(input);

            //Assert
            Assert.AreEqual(expectedOutput, output);            
        }

        [TestMethod]
        [DataRow(new int[6] { 7, 1, 5, 3, 6, 4 }, 5)]
        [DataRow(new int[5] { 7, 6, 4, 3, 1 }, 0)]
        [DataRow(new int[0] { }, 0)]
        [DataRow(null, 0)]
        [DataRow(new int[1] { 9 }, 0)]
        public void MaxProfit(int[] input, int expectedOutput)
        {
            //Arrange
            var tester = new ExampleQuestions_DynamicProgramming();

            //Act
            var output = tester.MaxProfit(input);

            //Assert
            Assert.AreEqual(expectedOutput, output);
        }
    }
}
