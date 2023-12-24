using System.Security.Cryptography.X509Certificates;

namespace LeetCode.Algorithms
{
    //https://leetcode.com/problems/majority-element
    public class MajorityElement 
    {
        public static int Run(List<int> nums)
        {
            int result = 0;
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Count; i++)
            {
                if (keyValuePairs.ContainsKey(nums[i]))
                {
                    keyValuePairs[nums[i]]++;
                }
                else
                {
                    keyValuePairs.Add(nums[i], 0);
                }
            }

            result = keyValuePairs.Where( x=> x.Value == keyValuePairs.Max(y => y.Value)).First().Key;

            return result;  
        }
    }
}
