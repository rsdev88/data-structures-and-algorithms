using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.Algorithms
{
    public class DynamicProgramming
    {
        // The normal recursive Fibonacci solution is not only space inefficient due to the large call stack it takes up,
        // but also because of overlapping subproblems, i.e. repeatedly performing calculations for the same input.
        // By using memoization to cache calculation for previously seen inputs, this is Dynamic Programming and it
        // will reduce the time complexity to O(n).


        private Dictionary<int, int> cache = new Dictionary<int, int>();

        //Time complexity = O(n) - very good compared to unmemoized fibonacci which was O(2^n)
        //Space complexity = larger than unmemoized because of growing cache.
        public int Memoized_Fibonacci(int n)
        {
            if (n < 2)
            {
                return n;
            }

            //check the cache to see if we've seen this input before
            if (this.cache.ContainsKey(n))
            {
                //Retrieving data from a hashtable is O(1).
                return this.cache[n];
            }

            //If we get this far, we haven't seen this input before - calculate the result and add it to the cache
            var result = Memoized_Fibonacci(n - 1) + Memoized_Fibonacci(n - 2);
            this.cache.Add(n, result);

            return result;

        }
    }
}
