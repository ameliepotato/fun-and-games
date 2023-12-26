using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://leetcode.com/problems/majority-element

namespace LeetCode.Algorithms
{
    public class RotateArray
    {
        public static void Run(int[] nums, int k)
        {
            CommonTools.PrintCollection(nums);
            for (int i = 0; i < k; i++)
                {
                    RunOnce(nums);
                }
            CommonTools.PrintCollection(nums);
        }

        public static int _step { get; private set; } = 1;
        public static void RunOnce(int[] nums)
        {
            Console.WriteLine($"Moving collection step {_step}: \n\t{CommonTools.PrintCollection(nums)}");
            int last = nums[nums.Length-1];
            for (int i = nums.Length-1; i>0; i--)
            {
                {
                    var temp = nums[i - 1];
                    nums[i - 1] = nums[i];
                    nums[i] = temp;
                }
            }
            nums[0] = last;
            Console.WriteLine($"Moved collection: \n\t{CommonTools.PrintCollection(nums)}");
            _step++;
        }
    }
}
