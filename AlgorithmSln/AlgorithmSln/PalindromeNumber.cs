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
            if (x > -1 && x < 10)
            {
                return true;
            }
            string str = Convert.ToString(x);
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < str.Length / 2; i++)
            {
                stack.Push(str[i]);
            }
            int temp = 0;
            if (str.Length % 2 == 0)
            {
                temp = str.Length / 2 ;
            }
            else
            {
                temp = str.Length / 2 + 1;
            }
            for (int i = temp; i < str.Length; i++)
            {
                if (str[i] == stack.Peek())
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            if (stack.Count==0)
            {
                return true;
            }
            return false;
        }
    }
}
