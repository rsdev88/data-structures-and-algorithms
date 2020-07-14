using DataStructuresAndAlgorithms.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresAndAlogrithmsTests.DataStructures
{
    [TestClass]
    public class TrieTests
    {
        Trie trie;

        [TestInitialize]
        public void TrieTests_Setup()
        {
            //Arrange
            this.trie = new Trie();
        }

        [TestMethod]
        public void TrieTests_EmptyTrie()
        {
            //Assert
            Assert.AreEqual(0, trie.WordCount);
        }

        [TestMethod]
        public void TrieTests_Insert()
        {
            //Act
            this.trie.Insert("hello");
            this.trie.Insert("world");

            //Assert
            Assert.AreEqual(2, trie.WordCount);
        }

        [TestMethod]
        public void TrieTests_PrefixSearch()
        {
            //Act
            this.trie.Insert("dogs");
            this.trie.Insert("cats");
            this.trie.Insert("snakes");
            this.trie.Insert("chimps");

            //Assert
            Assert.AreEqual(4, trie.WordCount);
            Assert.IsTrue(trie.ContainsPrefix("d"));
            Assert.IsTrue(trie.ContainsPrefix("do"));
            Assert.IsTrue(trie.ContainsPrefix("dog"));
            Assert.IsTrue(trie.ContainsPrefix("dogs"));

            Assert.IsTrue(trie.ContainsPrefix("c"));
            Assert.IsTrue(trie.ContainsPrefix("ca"));
            Assert.IsTrue(trie.ContainsPrefix("cat"));
            Assert.IsTrue(trie.ContainsPrefix("cats"));

            Assert.IsTrue(trie.ContainsPrefix("s"));
            Assert.IsTrue(trie.ContainsPrefix("sn"));
            Assert.IsTrue(trie.ContainsPrefix("sna"));
            Assert.IsTrue(trie.ContainsPrefix("snak"));
            Assert.IsTrue(trie.ContainsPrefix("snake"));
            Assert.IsTrue(trie.ContainsPrefix("snakes"));

            Assert.IsTrue(trie.ContainsPrefix("c"));
            Assert.IsTrue(trie.ContainsPrefix("ch"));
            Assert.IsTrue(trie.ContainsPrefix("chi"));
            Assert.IsTrue(trie.ContainsPrefix("chim"));
            Assert.IsTrue(trie.ContainsPrefix("chimp"));
            Assert.IsTrue(trie.ContainsPrefix("chimps"));

            Assert.IsFalse(trie.ContainsPrefix("h"));
            Assert.IsFalse(trie.ContainsPrefix("ho"));
            Assert.IsFalse(trie.ContainsPrefix("hor"));
            Assert.IsFalse(trie.ContainsPrefix("hors"));
            Assert.IsFalse(trie.ContainsPrefix("horse"));
        }

        [TestMethod]
        public void TrieTests_WordSearch()
        {
            //Act
            this.trie.Insert("dogs");
            this.trie.Insert("cats");
            this.trie.Insert("snakes");
            this.trie.Insert("chimps");

            //Assert
            Assert.AreEqual(4, trie.WordCount);
            Assert.IsTrue(trie.ContainsWord("dogs"));
            Assert.IsTrue(trie.ContainsWord("cats"));
            Assert.IsTrue(trie.ContainsWord("snakes"));
            Assert.IsTrue(trie.ContainsWord("chimps"));

            Assert.IsFalse(trie.ContainsWord("dog"));
            Assert.IsFalse(trie.ContainsWord("cat"));
            Assert.IsFalse(trie.ContainsWord("snake"));
            Assert.IsFalse(trie.ContainsWord("chimp"));
            Assert.IsFalse(trie.ContainsWord("horse"));
        }
    }
}
