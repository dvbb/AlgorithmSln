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
    }
}
