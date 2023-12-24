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
            Console.WriteLine($"MaxProfit with: {CommonTools.PrintCollection(nums.ToList())}");
            int maxProfit = int.MinValue;
            int lastProfit = 0;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                var profitIfBuyTodayAndSellTomorrow = nums[i + 1] - nums[i];

                lastProfit = lastProfit + profitIfBuyTodayAndSellTomorrow;
                if (lastProfit < profitIfBuyTodayAndSellTomorrow) 
                    lastProfit = profitIfBuyTodayAndSellTomorrow;

                if (lastProfit > maxProfit)
                    maxProfit = lastProfit;
            }
            return maxProfit < 0 ? 0 : maxProfit;
        }
    }
}
