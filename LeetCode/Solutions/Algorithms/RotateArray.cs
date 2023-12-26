using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

//https://leetcode.com/problems/majority-element

namespace LeetCode.Algorithms
{
    public class RotateArray
    {
        public static void Run(int[] nums, int k)
        {

            Console.WriteLine($"Rotating collection: \n\t{CommonTools.PrintCollection(nums)}");

            if (k >= nums.Length)
            {
                k = k % nums.Length;
            }

            MoveSubArrayAtTheEnd(nums, 0, nums.Length - k, k);
            Console.WriteLine($"Rotated collection to: \n\t{CommonTools.PrintCollection(nums)}");
        }

        public static void MoveSubArrayAtTheEnd(int[] nums, int start, int length, int k)
        { 
            Range rangeSubArray = new Range(start, start + length);
            Range rangeLastArray = new Range(start + length, nums.Length);

            var subArray = nums.Take(rangeSubArray).ToArray();
            var lastArray = nums.Take(rangeLastArray).ToArray();
            lastArray.CopyTo(nums, start);
            subArray.CopyTo(nums, nums.Length - length);
        }
    }
}
