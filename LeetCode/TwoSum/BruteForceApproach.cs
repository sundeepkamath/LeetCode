using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.TwoSum
{
    //Time Complexity: O(n2)
    //Space Complexity: O(1)
    class BruteForceApproach
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
            for (int i = 0; i <= nums.Length-1; i++)
            {
                for (int j = i + 1; j <= nums.Length - 1; j++)
                {
                    if(nums[i] + nums[j] == target)
                        return new int[]{i, j};
                }
            }
            throw new ArgumentException("No Two Sum solution");
        }
    }
}
