using DataStructuresAndAlgorithms.BigONotation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresAndAlogrithmsTests.BigONotation
{
    [TestClass]
    public class TimeComplexityTests
    {
        [TestMethod]
        public void TimeComplexity_Tests()
        {
            var processor = new TimeComplexity();

            Assert.AreEqual(500500, processor.AddAllNumbersFromOneToNUsingMaths(1000));
            Assert.AreEqual(500500, processor.AddAllNumbersFromOneToNUsingLoops(1000));

            Assert.AreEqual(36, processor.LogAllPairs(new int[] { 1, 2, 3, 4, 5, 6 }).Count);
        }
    }
}
