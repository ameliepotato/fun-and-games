using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://leetcode.com/problems/majority-element

namespace LeetCode.Algorithms
{
    public class RotateArray
    {
        public static void Run(List<int> nums, int k)
        {
            CommonTools.PrintCollection(nums);
            for (int i = 0; i < k; i++)
                {
                    RunOnce(nums);
                }
            CommonTools.PrintCollection(nums);
        }

        public static void RunOnce(List<int> nums)
        {
            CommonTools.PrintCollection(nums);
            int first = nums[0];
            for (int i = 0; i < nums.Count()-1; i++)
            {
                {
                    var temp = nums[i + 1];
                    nums[i + 1] = nums[i];
                    nums[i] = temp;
                }
            }
            nums[nums.Count-1] = first;
            CommonTools.PrintCollection(nums);
        }
    }
}
