using System;

namespace DataStructuresAndAlgorithms.ExampleQuestions
{
    public class ExampleQuestions_Recursion
    {

        /* 
         * Write two functions that find the factorial of any number. 
         * One should be recursive, the other should be iterative.
         */

        //O(n) time complexity
        //O(n) space complexity (call stack grows)
        public int FindFactorialRecursive(int number)
        {
            if (number <= 1)
            {
                return number;
            }

            return (number * FindFactorialRecursive(number - 1));
        }


        //O(n) time complexity
        //O(1) space complexity
        public int FindFactorialIterative(int number)
        {
            if (number == 0 || number == 1 || number == 2)
            {
                return number;
            }

            int sum = 1;

            for (int i = number; i >= 2; i--)
            {
                sum = sum * i;
            }

            return sum;
        }


        /* 
         * Write two functions that given a number n, return the Fibonacci value at the nth position (n is 0 based)
         * One should be recursive, the other should be iterative.
         * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144...
         */


        //O(2^n) (exponential) time - very bad!
        //O(n) space (call stack increases)
        public int Fibonacci_Recursive(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return Fibonacci_Recursive(n - 1) + Fibonacci_Recursive(n - 2);

        }

        //O(n) time
        //O(1) space
        public int Fibonacci_Iterative(int n)
        {

            if (n <= 1)
            {
                return n;
            }

            int firstNumber = 0;
            int secondNumber = 1;

            for (int i = 0; i < n - 1; i++)
            {
                int sum = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = sum;
            }

            return secondNumber;
        }
    }
}
