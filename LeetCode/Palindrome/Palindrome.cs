using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Palindrome
{
    class Palindrome
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[] {1,4,4,1};

            bool isPalindrome = IsPalindrome(nums);
            Console.WriteLine($"isPalindrome: {isPalindrome}");
        }

        private static bool IsPalindrome(int[] nums)
        {
            int i = 0, j = nums.Length - 1;

            while (i <= j)
            {
                if (nums[i++] != nums[j--])
                    return false;
            }

            return true;
        }
    }
}
