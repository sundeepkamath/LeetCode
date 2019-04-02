using System;
using System.Runtime.InteropServices;

namespace LeetCode.ReverseInteger
{
    public class ReverseInteger
    {
        public static void Main(string[] args)
        {
            int number = 12521;

            Console.WriteLine(IsPalindrome(number));
        }

        private static bool IsPalindrome(int number)
        {
            if (number < 0 || number % 10 == 0)
                return false;

            int reverseNum = 0;
            while (number > reverseNum)
            {
                reverseNum = reverseNum * 10 + (number % 10);
                number /= 10;
            }

            return reverseNum == number || number == (reverseNum / 10);
        }
    }
}