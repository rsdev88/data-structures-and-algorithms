using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructuresAndAlgorithms.DataStructures
{
    public class HashTable
    {
        private List<KeyValuePair<string, string>>[] data;
        // Building a hashtable to show how it works behind the scenes
        // I've used a dictionary for the underlying data for simplicity.

        public HashTable(int size)
        {
            //An array of lists of key value pairs (for dealing with collisions)
            this.data = new List<KeyValuePair<string, string>>[size];           
        }

        public int Length
        {
            get { return this.data.Length; }
        }


        private int HashFunction(string key)
        {
            var hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hash = (hash + (int)key[i] * i) % this.data.Length;
            }

            return hash;
        }

        public void Set(string key, string value)
        {
            var index = HashFunction(key);

            // Handle memory slots that haven't been added to yet.
            if (this.data[index] == null)
            {
                this.data[index] = new List<KeyValuePair<string, string>>();
            }

            this.data[index].Add(new KeyValuePair<string, string>(key, value));
        }

        public string Get(string key)
        {
            var index = HashFunction(key);
            var bucket = this.data[index];

            return bucket.First(item => (item.Key == key)).Value ?? string.Empty;
        }
    }
}
