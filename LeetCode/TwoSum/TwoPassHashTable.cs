using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.TwoSum
{
    //Time Complexity: O(n)
    //Space Complexity: O(n)
    class TwoPassHashTable
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[] {2, 4, 6, 8, 3};
            int target = 8;

            int[] result = TwoSum(nums, target);
            Console.WriteLine(string.Join(',', result));
        }

        private static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int,int> table = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                table[nums[i]] = i;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                int complement = target - nums[j];
                if (table.ContainsKey(complement) && table[complement] != j)
                    return new int[] {j, table[complement] };
            }
            throw new ArgumentException("No Two Sum solution");
        }
    }
}