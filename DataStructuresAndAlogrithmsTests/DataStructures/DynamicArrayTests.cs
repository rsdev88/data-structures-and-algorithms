using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructuresAndAlgorithms.DataStructures;

namespace DataStructuresAndAlogrithmsTests.DataStructuresTests
{
    [TestClass]
    public class DynamicArrayTests
    {
        [TestMethod]
        public void DynamicArray_Push()
        {
            //Arrange
            var myArray = new DynamicArray<string>();

            //Act
            myArray.Push("Hello");
            myArray.Push("World");

            Assert.AreEqual(2, myArray.Length);
            Assert.AreEqual("Hello", myArray.GetItem(0));
            Assert.AreEqual("World", myArray.GetItem(1));
        }

        [TestMethod]
        public void DynamicArray_Delete()
        {
            //Arrange
            var myArray = new DynamicArray<string>();

            //Act
            myArray.Push("1");
            myArray.Push("2");
            myArray.Push("3");
            myArray.Push("4");
            myArray.Push("5");
            myArray.Delete(2);

            Assert.AreEqual(4, myArray.Length);
            Assert.AreEqual("1", myArray.GetItem(0));
            Assert.AreEqual("2", myArray.GetItem(1));
            Assert.AreEqual("4", myArray.GetItem(2));
            Assert.AreEqual("5", myArray.GetItem(3));
        }

        [TestMethod]
        public void DynamicArray_Insert()
        {
            //Arrange
            var myArray = new DynamicArray<string>();

            //Act
            myArray.Push("1");
            myArray.Push("2");
            myArray.Push("4");
            myArray.Push("5");
            myArray.Insert(2, "3");

            Assert.AreEqual(5, myArray.Length);
            Assert.AreEqual("1", myArray.GetItem(0));
            Assert.AreEqual("2", myArray.GetItem(1));
            Assert.AreEqual("3", myArray.GetItem(2));
            Assert.AreEqual("4", myArray.GetItem(3));
            Assert.AreEqual("5", myArray.GetItem(4));
        }
    }
}
