using System;
using System.Collections.Generic;

namespace LeetCode.TwoSum
{
    //Time Complexity: O(n)
    //Space Complexity: O(n)
    class OnePassHashTable
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 4, 6, 8, 3 };
            int target = 8;

            int[] result = TwoSum(nums, target);
            Console.WriteLine(string.Join(',', result));
        }

        private static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> table = new Dictionary<int, int>();
            
            for (int j = 0; j < nums.Length; j++)
            {
                int complement = target - nums[j];
                if (table.ContainsKey(complement))
                    return new int[] { table[complement], j };

                table[nums[j]] = j;
            }
            throw new ArgumentException("No Two Sum solution");
        }
    }
}