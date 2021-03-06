﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.ExampleQuestions
{
    public class ExampleQuestions_DynamicProgramming
    {
        /*
         * From https://leetcode.com/problems/house-robber/
         You are a professional robber planning to rob houses along a street. 
         Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is 
         that adjacent houses have security system connected and it will automatically contact the police if two adjacent 
         houses were broken into on the same night.

         Given a list of non-negative integers representing the amount of money of each house, determine the maximum amount 
         of money you can rob tonight without alerting the police.
         
        Example 1:
        Input: nums = [1,2,3,1]
        Output: 4
        Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
                     Total amount you can rob = 1 + 3 = 4.
        Example 2:
        Input: nums = [2,7,9,3,1]
        Output: 12
        Explanation: Rob house 1 (money = 2), rob house 3 (money = 9) and rob house 5 (money = 1).
                     Total amount you can rob = 2 + 9 + 1 = 12.


        HINT - you cannot just rob odds and evens due to the following example.
        Example 3:
        Input: nums = [2,1,1,2]
        Output: 4
        Explanation: Rob house 1 (money = 2) and rob house 4 (money = 2).
                     Total amount you can rob = 2 + 2 = 4.
         */


        /*
         Solution: keep an array of the running total, with each index representing the choice that will give us the most money to that point.
         House 1 - take what's in the house - that becomes runningTotal[0]
         House 2 - decide whether to keep runningTotal[0] or what's in the house - that becomes runningTotal[1]
         House 3 onwards - choose the greater of either (and add to the runningTotal):
                                    - the sum of the max you could take 2 houses ago + the current house
                                    - the sum of the max you could take 1 house ago (and skip the current house)
         Return the last item in the runningTotal array.  
         
        This is dynamic programming because you're storing calculated values so you don't need to repeat calculations.
             
        O(n) time - one pass through the whole array
        O(n) space - the runningTotal array grows as we iterate through the input array.
             */
        public int RobHouse(int[] nums)
        {
            //No houses
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            //1 house
            if (nums.Length == 1)
            {
                return nums[0];
            }

            //2 houses onwards
            List<int> runningTotal = new List<int>();
            runningTotal.Add(nums[0]); //1st house
            runningTotal.Add(Math.Max(nums[0], nums[1])); //2nd house

            for (int i = 2; i < nums.Length; i++) //nth house
            {
                runningTotal.Add(Math.Max(nums[i] + runningTotal[i - 2], runningTotal[i - 1]));
            }

            return runningTotal[runningTotal.Count - 1];
        }

        /*
         * From https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
         * 
         * Say you have an array for which the ith element is the price of a given stock on day i.

            If you were only permitted to complete at most one transaction 
            (i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.

            Note that you cannot sell a stock before you buy one.

            Example 1:
            Input: [7,1,5,3,6,4]
            Output: 5
            Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
                         Not 7-1 = 6, as selling price needs to be larger than buying price.
            Example 2:
            Input: [7,6,4,3,1]
            Output: 0
            Explanation: In this case, no transaction is done, i.e. max profit = 0.   
         */

        /*
        Solution:
        Loop through the array, keeping track of the mininum price seen so far, 
        and the maximum profit seen so far, which is the greater of either
        - the current maximum profit
        - the current value minus the minumum price so far

        This uses dynamic programming because we're storing the max profit so far.

        O(n) time - one pass through the whole array
        O(1) space - the variables we're keeping track of are being overwritten, so their size is not
                    dependent on the size of the input array.
        */

        public int MaxProfit(int[] prices)
        {

            if (prices == null || prices.Length < 2)
            {
                return 0;
            }

            int minPrice = prices[0];
            int maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {

                maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
                minPrice = Math.Min(minPrice, prices[i]);
            }

            return maxProfit;
        }
    }
}
