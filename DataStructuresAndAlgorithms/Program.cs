using DataStructuresAndAlgorithms.BigONotation;
using System;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new TimeComplexity();
            processor.AddAllNumbersFromOneToNUsingMaths(1000);
            processor.AddAllNumbersFromOneToNUsingLoops(1000);
            processor.LogAllPairs(new int[] { 1, 2, 3, 4, 5, 6 });

            Console.ReadLine();
        }
    }
}
