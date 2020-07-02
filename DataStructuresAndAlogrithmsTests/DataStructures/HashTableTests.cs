using DataStructuresAndAlgorithms.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresAndAlogrithmsTests.DataStructures
{
    [TestClass]
    public class HashTableTests
    {
        HashTable phoneNumbers;

        [TestInitialize]
        public void HashTableTestsSetup()
        {
            this.phoneNumbers = new HashTable(3);
        }

        [TestMethod]
        public void HashTableTest_SetAndGet()
        {
            //Arrange
            var expectedOutputRob = "012345656";
            var expectedOutputHannah = "09898723412";
            var expectedOutputAlice = "09567568234232";
            var expectedOutputJames = "0983453453412";


            //Act - hashtable size is only 3 but we're adding 4 items, so this will ensure some items are added to the same address in memory, checking that linked list buckets work.
            this.phoneNumbers.Set("Rob", expectedOutputRob);
            this.phoneNumbers.Set("Hannah", expectedOutputHannah);
            this.phoneNumbers.Set("Alice", expectedOutputAlice);
            this.phoneNumbers.Set("James", expectedOutputJames);

            //Assert
            Assert.AreEqual(3, this.phoneNumbers.Length);
            Assert.AreEqual(expectedOutputRob, this.phoneNumbers.Get("Rob"));
            Assert.AreEqual(expectedOutputHannah, this.phoneNumbers.Get("Hannah"));
            Assert.AreEqual(expectedOutputAlice, this.phoneNumbers.Get("Alice"));
            Assert.AreEqual(expectedOutputJames, this.phoneNumbers.Get("James"));
        }

    }
}
