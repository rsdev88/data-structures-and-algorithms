using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.ExampleQuestions
{
    public class ExampleQuestions
    {
        /* Question 1:
         * ************
         * Given 2 arrays, create a function that lets a user know (true/false) whether the two arrays share any common items.
         * 
         * e.g.
         * const array1 = ['a', 'b', 'c', 'x'];
         * const array2 = ['z', 'y', 'i'];
         * should return false
         * 
         * const array1 = ['a', 'b', 'c', 'x'];
         * const array2 = ['z', 'y', 'x'];
         * should return true
        */


        // Time complexity = O(n * m) - horrible!
        // Space complextiy = O(1) - very good.
        public bool QuestionOneBruteForceApproach(char[] array1, char[] array2)
        {
            foreach (char item1 in array1)
            {
                foreach(char item2 in array2)
                {
                    if (item1 == item2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // Time complexity = O(m + n) - much better than before!
        // Space complexity = O(m) - worse than before.
        public bool QuestionOneUsingAHashTable(char[] array1, char[] array2)
        {
            //create a hash table that contains a key for each item in array1 with a value of true
            var map = new Hashtable();

            foreach(char item in array1)
            {
                if(map[item] == null) // Only add the item in if it doesn't already exist.
                {
                    map.Add(item, true);
                }
            }

            //loops through array2 and see if the item is contained in the hash table.
            foreach (char item in array2)
            {
                if(map[item] != null)
                {
                    return true;
                }
            }

            return false;
        }


        /* Question 2 (the one from Google's example):
         * ************
         * Given an array and an int, create a function that lets a user know (true/false) 
         * whether any pair of items in the array add up to the integer.
         * 
         * e.g.
         * const array = [1, 2, 3, 4, 9];
         * const sum = 8
         * should return false
         * 
         * const array = [1, 2, 3, 4, 4];
         * const sum = 8
         * should return true
         * 
         * 
         * Questions asked of interviewer:
         * Q. Potential size of the array? A. Very large --> think efficiency
         * Q. Can you have negative items? A. Yes
         * Q. Are the array items always ordered? A. No.
        */

        // Time complexity = O(n^2) - very bad!
        // Space complexity = O(1) - very good.
        public bool QuestionTwoBruteForceApproach(int[] array, int sum)
        {
            for(int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j && array[i] + array [j] == sum)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        // Time complexity = O(n) - much better! (hashset searching has O(1) time complexity)
        // Space complexity = O(n) - not as good - our hashset grows with the array size.
        public bool QuestionTwoUsingHashSet(int[] array, int sum)
        {
            //For each item in the array, build up a hashset of it's compliment (i.e. sum - item) and compare the item to the data in the
            // set to see if we've already had it.
            // e.g. given [3, 2, 2, 1, 5, 4, 6, 7]
            // the hashset will grow like
            // - Is 3 in the hashset? No, ok insert 5 -> {5}
            // - Is 2 in the hashset? No, ok insert 6 -> {5, 6}
            // - Is 2 in the hashset? No, ok insert 6 -> {5, 6, 6}
            // - Is 1 in the hashset? No, ok insert 7 -> {5, 6, 6, 7}
            // - Is 5 in the hashset? Yes - this means we must have come across 3 already, so we know we have a pair - return true.

            HashSet<int> hashSet = new HashSet<int>();

            for(int i = 0; i < array.Length; i++)
            {
                if (hashSet.Contains(array[i]))
                {
                    return true;
                }
                hashSet.Add(sum - array[i]);
            }

            return false;
        }
    }
}
