using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    //https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii
    public class RemoveDuplicatesFromSortedArrays 
    {
        public static int Run(ref List<int> nums)
        {
            Console.WriteLine($"Input lenght {nums.Count()}: {CommonTools.PrintCollection(nums.ToList())}");
            int newLenght = nums.Count();

            for (int i = 2; i < newLenght; i++)
            {
                if (nums[i] == nums[i - 1] && nums[i] == nums[i - 2])
                {
                    for (int j = i; j < newLenght - 1; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    newLenght--;
                    i--;
                }
            }
            Console.WriteLine($"Output lenght {newLenght}:" +
                $" {CommonTools.PrintCollection<int>(nums.Take(newLenght).ToList())}");
            return newLenght;
        }
    }
}
