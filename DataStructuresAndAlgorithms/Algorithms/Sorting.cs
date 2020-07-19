using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Algorithms
{
    public class Sorting
    {

        /*
            For the sake of simplicity, I've omitted null checks, one-item list checks etc,
            from each sort method, but these would be included in production.
        */


        //Time complexity = O(n^2)
        //Space complexity = O(1)
        //Take each pair of items in the term and swap them if the left one is higher than the right, so the
        //smaller items bubble to the top. Keep passing over the list until there's a pass where no swaps
        //are performed.
        public List<int> BubbleSort(List<int> unsortedList)
        { 
            bool keepLooping = true;

            while (keepLooping == true) //This will potentially loop as many times as the list is long.
            {
                keepLooping = false;

                for (int i = 0; i < unsortedList.Count - 1; i++)
                {
                    if (unsortedList[i] > unsortedList[i+1])
                    {
                        //Swap the items and indicate that a second pass is needed
                        keepLooping = true;
                        var secondItem = unsortedList[i + 1];
                        unsortedList[i + 1] = unsortedList[i];
                        unsortedList[i] = secondItem;
                    }
                }
            }

            return unsortedList;
        }

        
        //Time complexity O(n^2)
        //Space complexity O(1)
        //Go through the list keeping track of the smallest item found so far. 
        //Once you reach the end of the list, put that item in position 0.
        //Repeat, and put the next smallest in position 1... etc
        public List<int> SelectionSort(List<int> unsortedList)
        {
            for(int i = 0; i < unsortedList.Count; i++)
            {
                var lowestSoFar = unsortedList[i];
                var positionOfLowestSoFar = i;

                //Go through the list, starting from position i (everything before this is already sorted).
                //Keep track of the lowest number seen and its position.
                for (int j = i; j < unsortedList.Count; j++)
                {
                    if (unsortedList[j] < lowestSoFar)
                    {
                        lowestSoFar = unsortedList[j];
                        positionOfLowestSoFar = j;
                    }
                }

                //Swap the lowest with the starting position if it wasn't already in that position.
                if(positionOfLowestSoFar != i)
                {
                    unsortedList[positionOfLowestSoFar] = unsortedList[i];
                    unsortedList[i] = lowestSoFar;
                }
            }

            return unsortedList;
        }

        //Time complexity - O(n^2) worst case, but can be O(n) if list is nearly sorted
        //Space complexity - O(1)
        //Go through each item in the list, and place it in its appropriate place in a growing list of the
        //items that came before it, whilst simultaneously popping it off the original list to keep space
        //complexity to O(1) and not O(n).
        
        public List<int> InsertionSort(List<int> unsortedList)
        {
            List<int> sortedList = new List<int>();

            //for (int i = 0; i < unsortedList.Count; i++)
            while (unsortedList.Count > 0)
            {

                //For the first time, just add it to the sorted list and remove it from the unsorted.
                if(sortedList.Count == 0)
                {
                    sortedList.Add(unsortedList[0]);
                    unsortedList.RemoveAt(0);
                    continue;
                }

                //Iterate through the sorted list, deciding where to put the item from the unsorted list.
                for (int j = 0; j < sortedList.Count; j++)
                {
                    if(sortedList[j] >= unsortedList[0])
                    {
                        sortedList.Insert(j, unsortedList[0]);
                        break;
                    }

                    if(j == sortedList.Count - 1)
                    {
                        sortedList.Add(unsortedList[0]);
                        break;
                    }
                }

                //Remove the i'th item from the unsorted list to keep space complexity down.
                unsortedList.RemoveAt(0);
            }

            return sortedList;
        }

    }
}
