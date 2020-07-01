using DataStructuresAndAlgorithms.ExampleQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresAndAlogrithmsTests.ExampleQuestionsTests
{
    [TestClass]
    public class ExampleQuestionsTests
    {

        char[] array1;
        char[] array2;
        char[] array3;
        int[] array4;
        int[] array5;
        int[] array6;
        ExampleQuestions exampleQuestions;

        [TestInitialize]
        public void ExampleQuestionTests()
        {
            this.array1 = new char[] { 'a', 'b', 'c', 'x'};
            this.array2 = new char[] { 'z', 'y', 'x' };
            this.array3 = new char[] { 'z', 'y', 'i' };
            this.array4 = new int[] { 1, 2, 3, 4, 4 };
            this.array5 = new int[] { 1, 2, 3, 4, 9 };
            this.array6 = new int[] { -1, 2, 2, 1, 5, 9, 4, 6, 7 };

            this.exampleQuestions = new ExampleQuestions();
        }

        [TestMethod]
        public void QuestionOneBruteForceApproach_TrueCase()
        {
            //Arrage

            //Act
            var result = exampleQuestions.QuestionOneBruteForceApproach(this.array1, this.array2);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void QuestionOneBruteForceApproach_FalseCase()
        {
            //Arrage

            //Act
            var result = exampleQuestions.QuestionOneBruteForceApproach(this.array1, this.array3);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void QuestionOneHashTableApproach_TrueCase()
        {
            //Arrage

            //Act
            var result = exampleQuestions.QuestionOneUsingAHashTable(this.array1, this.array2);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void QuestionOneHashTableApproach_FalseCase()
        {
            //Arrage

            //Act
            var result = exampleQuestions.QuestionOneUsingAHashTable(this.array1, this.array3);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void QuestionTwoBruteForceApproach_TrueCase()
        {
            //Arrage
            int sum = 8;

            //Act
            var result = exampleQuestions.QuestionTwoBruteForceApproach(this.array4, sum);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void QuestionTwoBruteForceApproach_FalseCase()
        {
            //Arrage
            int sum = 8;

            //Act
            var result = exampleQuestions.QuestionTwoBruteForceApproach(this.array5, sum);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void QuestionTwoBruteForceApproach_WithNegativeNumbers()
        {
            //Arrage
            int sum = 8;

            //Act
            var result = exampleQuestions.QuestionTwoBruteForceApproach(this.array6, sum);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void QuestionTwoHashSetApproach_TrueCase()
        {
            //Arrage
            int sum = 8;

            //Act
            var result = exampleQuestions.QuestionTwoUsingHashSet(this.array4, sum);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void QuestionTwoHashSetApproach_FalseCase()
        {
            //Arrage
            int sum = 8;

            //Act
            var result = exampleQuestions.QuestionTwoUsingHashSet(this.array5, sum);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void QuestionTwoHashSetApproach_WithNegativeNumbers()
        {
            //Arrage
            int sum = 8;

            //Act
            var result = exampleQuestions.QuestionTwoUsingHashSet(this.array6, sum);

            //Assert
            Assert.IsTrue(result);
        }
    }
}
