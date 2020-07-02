using DataStructuresAndAlgorithms.ExampleQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresAndAlogrithmsTests.ExampleQuestions
{
    [TestClass]
    public class ExampleQuestions_HashTablesTests
    {
        [TestMethod]
        public void RecurringNumbers_EmptyArray()
        {
            //Arrange
            var processor = new ExampleQuestions_HashTables();
            int[] array = new int[] { };

            //Act
            var output = processor.FirstRecurringValue(array);

            //Assert
            Assert.AreEqual(null, output);
        }

        [TestMethod]
        public void RecurringNumbers_RecurringNumbers()
        {
            //Arrange
            var processor = new ExampleQuestions_HashTables();
            int[] array1 = new int[] { 2, 5, 1, 2, 3, 5, 1, 2, 4 };
            int[] array2 = new int[] { 2, 1, 1, 2, 3, 5, 1, 2, 4 };
            int[] array3 = new int[] { 2, 5, 5, 2, 3, 5, 1, 2, 4 };

            //Act
            var output1 = processor.FirstRecurringValue(array1);
            var output2 = processor.FirstRecurringValue(array2);
            var output3 = processor.FirstRecurringValue(array3);

            //Assert
            Assert.AreEqual(2, output1);
            Assert.AreEqual(1, output2);
            Assert.AreEqual(5, output3);
        }

        [TestMethod]
        public void RecurringNumbers_NoRecurringNumbers()
        {
            //Arrange
            var processor = new ExampleQuestions_HashTables();
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] array2 = new int[] { 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] array3 = new int[] { 0, 9, 1, 8, 3, 7, 4, 6 };

            //Act
            var output1 = processor.FirstRecurringValue(array1);
            var output2 = processor.FirstRecurringValue(array2);
            var output3 = processor.FirstRecurringValue(array3);

            //Assert
            Assert.AreEqual(null, output1);
            Assert.AreEqual(null, output2);
            Assert.AreEqual(null, output3);
        }
    }
}
