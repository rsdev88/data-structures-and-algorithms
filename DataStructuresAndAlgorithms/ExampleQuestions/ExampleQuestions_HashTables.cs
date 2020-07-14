using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.ExampleQuestions
{
    public class ExampleQuestions_HashTables
    {
        //Google Question - given an array of numbers, return the first recurring value.

        //Given an array = [2,5,1,2,3,5,1,2,4]:
        //It should return 2

        //Given an array = [2,1,1,2,3,5,1,2,4]:
        //It should return 1

        //Given an array = [2,3,4,5]:
        //It should return undefined/null
        public int? FirstRecurringValue(int[] numbers)
        {
            if (numbers.Length < 1)
            {
                return null;
            }

            //A hashset is just a set of keys, no values - we don't need key value pairs here.
            HashSet<int> knownValues = new HashSet<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                //If the value already exists in the hashset, it means we've seen it before, so return it as the first recurring value.
                if (knownValues.Contains(numbers[i]))
                {
                    return numbers[i];
                }

                // Otherwise, at it to the list of known values
                knownValues.Add(numbers[i]);
            }

            //if we get to the this stage, the array had no repeating numbers so return null;
            return null;
        }
    }
}
