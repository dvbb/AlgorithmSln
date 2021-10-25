using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSln
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        // 3. Longest Substring Without Repeating Characters
        // Given a string s, find the length of the longest substring without repeating characters.

        //Input: s = "abcabcbb"
        //Output: 3
        //Explanation: The answer is "abc", with the length of 3.
        public int LengthOfLongestSubstring(string s)
        {
            int result = 0;
            int count = 0;
            int cur = 0;
            string substr = "";
            HashSet<char> hashSet = new HashSet<char>();
            //time cost too much, need optimization in next step
            while (s.Length > cur + result)
            {
                if (substr.Length == s.Length)
                {
                    result = substr.Length;
                    break;
                }
                if (cur + substr.Length >= s.Length)
                {
                    result = (result > substr.Length) ? result : substr.Length;
                    break;
                }
                if (!hashSet.Contains(s[count]))
                {
                    substr += s[count];
                    hashSet.Add(s[count]);
                    count++;
                }
                else
                {
                    result = (result > substr.Length) ? result : substr.Length;
                    cur++;
                    count = cur;
                    hashSet.Clear();
                    substr = "";
                }
            }
            return result;
        }
    }
}
