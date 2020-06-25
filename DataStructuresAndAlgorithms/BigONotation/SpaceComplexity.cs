using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.BigONotation
{
    public class SpaceComplexity
    {

        //What causes Space complexity?
        // - Declaring and/or allocating to variables and other data structures
        // - Function calls
        // Usually when we talk about space complexity, we're actually talking about auxillary space - that is, the amount of
        // additional space used by the function not including its inputs.

        //O(1)
        // The space that this function uses up in memory doesn't depend on how large n gets, so although it's time complexity
        // may be O(n), it's space complexity is just O(1).
        public void WriteHelloNTimes(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("Hello");
            }
        }

        // O(n)
        // The space that this function uses up in memory grows linearly with n - the larger n gets, the bigger the list gets.
        public void CreateAnArrayOfSizeN(int n)
        {
            var list = new List<string>();
            for (int i = 0; i <= n; i++)
            {
                list.Add("Hello");
            }
        }

    }
}
