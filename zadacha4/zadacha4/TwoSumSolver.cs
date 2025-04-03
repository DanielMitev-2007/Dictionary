using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha4
{
    internal class TwoSumSolver
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (dict.ContainsKey(complement))
                {
                    return new int[] { dict[complement], i }; 
                }

                if (!dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] = i;
                }
            }

            return new int[] { -1, -1 };
        }
    }
}
