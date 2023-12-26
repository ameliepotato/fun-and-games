using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    //https://leetcode.com/problems/jump-game
    public class JumpGame
    {
        public static bool Run(int[] nums)
        {
            Console.WriteLine($"JumpGame of {CommonTools.PrintCollection(nums.ToList())}");
            if(nums.Length < 2 )
                return true;
            _nums = nums;
            return AnyValidRoad(0);
        }

        private static int[] _nums = new int[] { };

        private static bool AnyValidRoad(int poz)
        {
            if (poz == _nums.Length - 1) return true;

            if (poz > _nums.Length - 1) return false;

            if (poz < 0) return false;

            int val = _nums[poz];

            while(val > 0)
            {
                
                if (AnyValidRoad(poz + val))
                {
                    return true;
                }
                else
                {
                    _nums[poz] = -1;
                    val--;
                }
            }
            return false;
        }
    }
}
