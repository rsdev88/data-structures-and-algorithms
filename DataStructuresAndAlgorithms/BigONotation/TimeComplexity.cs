using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.BigONotation
{
    public class TimeComplexity
    {
        // Rules:
        // - always use the WORST case scenario when describing time complexity if using Big O notation.
        // - remove the constants to simplify the notation.
        // - use different terms for each parameter.
        // - drop non-dominant terms e.g. O(n^2 + n) --> O(n^2).

        // O(1)
        // A function has contant time complexity, denoted as O(1) if the number of operations it has to perform
        // remains unchanged even as the size of the input grows.
        public int AddAllNumbersFromOneToNUsingMaths(int n)
        {
            return n * (n + 1) / 2;
        }


        // O(n)
        // A function has linear time complexity, denoted as O(n) if the number of operations it has to perform
        // scales linearly with the size in the input.
        // As this method runs a for loop an amount of times that linearly depends on the size of the input, its
        // time complexity is O(n).
        public int AddAllNumbersFromOneToNUsingLoops(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            return sum;
        }

        // O(max(m,n)) or O(m + n)
        // This is still linear.
        // One of the rules of Big O Notation is that you treat each input separately. This function's run time depends on both
        // the length of both inputs (m and n) or if one is significantly larger than the other, then just the maximum of the two.
        public void PerformTwoLoops(int[] arrayOne, int[] arrayTwo)
        {
            for (int i = 0; i < arrayOne.Length; i++)
            {
                Console.Write("Loop one: " + i.ToString() );
            }

            for (int j = 0; j < arrayTwo.Length; j++)
            {
                Console.Write("Loop two: " + j.ToString());
            }
        }

        // O(n^2)
        // A function has quadratic time complexity, denoted O(n^2) if the number of operation it has to perform depends on
        // the size of its input squared.
        // In this function, for each item in the array, we're looping over each item in the array - i.e. a nested loop.
        // A general rule of thumb is that nested loops result in exponent (i.e. ^2, ^3, ^4...etc) time complexity because longhand
        // it would be written O(n*n).
        // If you had two inputs and looped over them in a nested fashion, this means you'd have O(n*m).
        public List<string> LogAllPairs(int[] input)
        {
            List<string> output = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    output.Add(String.Format("{0},{1}", input[i].ToString(), input[j].ToString()));
                }
            }

            return output;
        }

        // Others - these will be covered in their respective algorithms:

        // https://www.bigocheatsheet.com/

        // O(log n) - Logarithmic time - usually searching algorithms, if they are sorted (Binary search) (not hash maps)
        // O(n log n) - Log linear time - usually for sorting operations
        // O(2^n) - Exponential time - usually for resursive algorithms that solve a problem of size n.
        // O(n!) - Factorial time - usually when you're adding a nested loop for every element - this is most expensive type of function.

    }
}
