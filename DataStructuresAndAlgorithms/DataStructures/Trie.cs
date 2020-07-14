using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.DataStructures
{

    public class TrieNode
    {
        //Note - //An array of nodes fixed to the size of the expected number of possible letters (26) can also be used instead of a dictionary/hash table.
        public Dictionary<char, TrieNode> Children { get; set; } 

        public bool IsEndOfWord { get; set; }

        public TrieNode()
        {
            this.Children = new Dictionary<char, TrieNode>();
            this.IsEndOfWord = false;
        }
    }

    public class Trie
    {
        private TrieNode root;
        public int WordCount { get; set; }

        public Trie()
        {
            this.root = new TrieNode();
            this.WordCount = 0;
        }

        //O(m) where m = length of new word.
        public void Insert(string newWord)
        {
            var currentNode = root;
            var charactersArray = newWord.ToCharArray();

            for (int i = 0; i < charactersArray.Length; i++)
            {
                if (currentNode.Children.ContainsKey(charactersArray[i]))
                {
                    //This letter already exists at this level - reuse it.
                    currentNode = currentNode.Children[charactersArray[i]];
                }
                else
                {
                    //Insert the letter into the list of children for this node.
                    var newNode = new TrieNode();

                    if (i == charactersArray.Length - 1)
                    {
                        newNode.IsEndOfWord = true;
                    }

                    currentNode.Children.Add(charactersArray[i], newNode);
                    currentNode = newNode;
                }
            }

            this.WordCount++;
        }

        //Useful for knowing if a partial word is present in the Trie
        //O(m) where m = length of search term.
        public bool ContainsPrefix(string searchTerm)
        {
            var currentNode = root;
            var charactersArray = searchTerm.ToCharArray();
            
            for (int i = 0; i < charactersArray.Length; i++)
            {
                if (currentNode.Children.ContainsKey(charactersArray[i]))
                {
                    currentNode = currentNode.Children[charactersArray[i]];
                }
                else
                {
                    return false;
                }
            }

            return true;
        }


        //Used to determine if a whole word is present in the trie.
        //Will not return true if the match is a part of a larger word, unless an end-of-word marker is present.
        //i.e. if "starts" has been added to the trie, but not "start", then searching for "start" will return false.
        //O(m) where m = length of search term.
        public bool ContainsWord(string searchTerm)
        {
            var currentNode = root;
            var charactersArray = searchTerm.ToCharArray();

            for (int i = 0; i < charactersArray.Length; i++)
            {
                if (currentNode.Children.ContainsKey(charactersArray[i]))
                {
                    currentNode = currentNode.Children[charactersArray[i]];

                    if (i == charactersArray.Length - 1)
                    {
                        if (currentNode.IsEndOfWord)
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }

            return false;
        }
    }
}
