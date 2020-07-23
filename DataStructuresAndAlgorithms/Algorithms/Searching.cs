using System.Collections.Generic;
using System.Linq;

namespace DataStructuresAndAlgorithms.Algorithms
{
    public class Searching<T>
    {
        // The most basic type of search - literally just iterates over a collection, checking
        // each item to see if it matches the search.
        // Typically built-in to many languages in the form of e.g. Array.IndexOf(), Array.Includes(), etc.
        // This example function returns the index of the search term if it's present in the list, else null.

        // Time complexity: O(n) - worst case when item is last in list, or not in list.
        //                  O(1) - best case when item is first in list.
        public int? LinearSearch(List<T> list, T searchTerm)
        {
            if (list == null)
            {
                return null;
            }

            for (int i = 0; i < list.Count; i++)
            {
                if(list[i].Equals(searchTerm))
                {
                    return i;
                }
            }

            return null;
        }

        //Data must be sorted prior to searching
        //Keep halving the search set by finding the median and comparing it to the search term.
        //Eliminate the right half of the list if the search term is less than the median, else the left half.
        //Repeate the process until either the search term is found or you've ruled out everything.

        //Can be done iteratively or recursively. The space complexity depends on the approach.
        //Here I've used recursion so the space complexity is higher than the iterative approach, but some 
        //may find it more readable.
        //Time complexity = O(log n) because the search set is halved on each comparison.
        public bool BinarySearch(List<int> list, int searchTerm)
        {
            if (list == null || list.Count == 0)
            {
                return false;
            }

            if (list.Count == 1)
            {
                return list[0] == searchTerm;
            }

            var medianIndex = list.Count / 2; //Integer division for when list.Count is even.

            if (searchTerm == list[medianIndex])
            {
                return true;
            }
            else if (searchTerm < list[medianIndex])
            {
                list = list.Take(medianIndex).ToList<int>();
            }
            else
            {
                list = list.TakeLast(list.Count - medianIndex).ToList<int>();
            }

            return BinarySearch(list, searchTerm);
        }
    }
}
