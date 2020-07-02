using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructuresAndAlgorithms.ExampleQuestions
{

    public class ExampleQuestions_Arrays
    {
        //Create a function that reverses a string:
        //"Hi, my name is Rob" should be "boR si eman ym ,iH"

        //Time complexity O(n)
        //Space complexity O(n)
        public string ReverseAString(string input)
        {

            if (string.IsNullOrEmpty(input) || input.Length < 2)
            {
                return input;
            }

            //convert string to charArray
            char[] characters = input.ToCharArray();

            //loop through the array backwards, appending to a stringbuilder as we go
            StringBuilder reversedString = new StringBuilder();

            for (int i = characters.Length - 1; i >= 0; i--)
            {
                reversedString.Append(characters[i]);
            }

            return reversedString.ToString();
        }

        //Create a function that merges two pre-sorted arrays resulting in a single sorted array.
        // e.g. [0, 3, 4, 31] + [4, 5, 30] --> [0, 3, 4, 4, 6, 30, 31]
        // (At this point in time, I haven't studied any sorting algorithms so this will be a naive / brute force approach)
        //Time capacity O(n*m) - as bad as O(n^2)
        //Space capacity O(n+m)
        public int[] MergeSortedArrays_BruteForce(int[] array1, int[] array2)
        {
            //Assume negatives are allowed, both arrays are always sorted and contain only ints.

            if (array1.Length == 0)
            {
                return array2;
            }

            if (array2.Length == 0)
            {
                return array1;
            }

            //Copy the first array to our output
            var output = array1.ToList<int>();

            //Loop through the second array, comparing its values to the items in the output and place accordingly
            for (int i = 0; i < array2.Length; i++)
            {
                var itemInserted = false;
                foreach (int item in output)
                {
                    if(array2[i] <= item)
                    {
                        output.Insert(output.IndexOf(item), array2[i]);
                        itemInserted = true;
                        break;
                    }
                }
                if(!itemInserted)
                {
                    output.Add(array2[i]);
                }
            }

            return output.ToArray();
        }

        // Better solution
        // Time complexity = O(n+m)
        // Space complexity = O(n+m)

        public int[] MergeSortedArrays_OofNSolution(int[] array1, int[] array2)
        {
            List<int> output = new List<int>();

            int i = 0;
            int j = 0;
            int array1Item = array1[i];
            int array2Item = array2[j];

            //Check inputs
            if (array1.Length == 0)
            {
                return array2;
            }

            if (array2.Length == 0)
            {
                return array1;
            }

            //Compare the numbers in the array starting from the left and moving the cursor one
            //to the right on whichever array item is bigger.
            while(i < array1.Length || j < array2.Length)
            {
                if(j >= array2.Length || array1[i] < array2[j])
                {
                    output.Add(array1[i]);
                    i++;
                }
                else
                {
                    output.Add(array2[j]);
                    j++;
                }
            }

            return output.ToArray();
        }
    }
}
