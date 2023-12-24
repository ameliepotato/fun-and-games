using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    //https://leetcode.com/problems/best-time-to-buy-and-sell-stock
    public class MaxProfit
    {
        public static int Run(int[] nums)
        {
            int p = 0;
            int min = 0;
            for(int i = 1; i < nums.Length; i++)
            {
                int d = nums[i] - nums[min];
                if (d > p)
                {
                    p = d;
                } 
                else if (d < 0)
                {
                    min = i;
                }

            }
            return p;


            //Console.WriteLine($"MaxProfit with: {CommonTools.PrintCollection(nums.ToList())}");
            //int maxProfit = 0;
            //int lastProfit = 0;
            //int profitIfBuyTodayAndSellTomorrow;
            //for (int i = nums.Length - 2; i >= 0; i--)
            //{
            //    profitIfBuyTodayAndSellTomorrow = nums[i + 1] - nums[i];

            //    lastProfit = lastProfit + profitIfBuyTodayAndSellTomorrow;
            //    if (lastProfit < profitIfBuyTodayAndSellTomorrow) 
            //        lastProfit = profitIfBuyTodayAndSellTomorrow;

            //    if (lastProfit > 0 && lastProfit > maxProfit)
            //        maxProfit = lastProfit;
            //}
            //return maxProfit;
        }
    }
}
