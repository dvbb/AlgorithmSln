using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Medium
{
    public class LongestPalindromicSubstring
    {
        /// <summary>
        /// Given a string s, return the longest palindromic substring in s.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string LongestPalindrome(string s)
        {
            if (s.Length <= 1)
            {
                return s;
            }
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                string temp = ExpandAroundCenter(s, i);
                if (temp.Length > result.Length)
                {
                    result = temp;
                }
            }
            return result;
        }
        private static string ExpandAroundCenter(string s, int cur)
        {
            int left = cur, right = cur;
            while (left > 0 && s[cur] == s[left - 1])
            {
                left--;
            }
            while (right < s.Length - 1 && s[cur] == s[right + 1])
            {
                right++;
            }
            while (left > 0 && right < s.Length - 1)
            {
                if (s[--left] != s[++right])
                {
                    left++;
                    right--;
                    break;
                }
            }
            return s.Substring(left, right - left + 1);
        }
    }
}
