using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSln
{
    public class PalindromeNumber
    {
        //9. Palindrome Number  [Easy]
        //Given an integer x, return true if x is palindrome integer.
        //An integer is a palindrome when it reads the same backward as forward.For example, 121 is palindrome while 123 is not.

        //Input: x = 121
        //Output: true

        /// <summary>
        /// 52 ms   30.7 MB
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            if (x < 10)
            {
                return true;
            }
            string str = Convert.ToString(x);
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < str.Length / 2; i++)
            {
                stack.Push(str[i]);
            }
            for (int i = str.Length / 2 + str.Length % 2; i < str.Length; i++)
            {
                if (stack.Pop()!=str[i])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 44 ms   29.2 MB
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool IsPalindromeV2(int x)
        {
            if (x < 0)
            {
                return false;
            }
            if (x < 10)
            {
                return true;
            }
            string nums = Convert.ToString(x);
            int i = 0;
            int j = nums.Length - 1;
            while (i != j && i < j)
            {
                if (nums[i] != nums[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}
