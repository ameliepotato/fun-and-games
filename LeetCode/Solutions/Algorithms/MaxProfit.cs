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
            int max = 0;
            int min = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (i==0 || nums[i]< min)
                {
                    min = nums[i];
                }
                else
                {
                    continue;
                }

                int mymax = GetMaxDistance(nums, i);
                if(mymax > max) 
                    max = mymax;
            }
            return max;
        }

        public static int GetMaxDistance(int[] nums, int i)
        {
            int max = 0;
            for (int j = i+1; j < nums.Length; j++)
            {
                if (nums[j] > nums[i] && (nums[j] - nums[i]) > max )
                {
                    max = nums[j]-nums[i];
                }
            }
            return max;
        }
    }
}
