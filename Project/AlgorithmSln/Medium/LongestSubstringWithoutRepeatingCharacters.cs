using System;
using System.Collections.Generic;
using System.Linq;
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

        /// <summary>
        /// 优化一下V1的写法，参数太多可读性很差
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstringV2(string s)
        {
            //处理边界值
            if (s.Length == 1)
            {
                return 1;
            }
            //确认可能的最大字串
            HashSet<char> hashSet = new HashSet<char>();
            for (int c = 0; c < s.Length; c++)
            {
                hashSet.Add(s[c]);
            }
            int expectedMax = hashSet.Count;
            if (expectedMax == s.Length)
            {
                return expectedMax;
            }

            // 循环找出最大字串
            int actualMax = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int currentMax = 0;
                hashSet.Clear();
                for (int j = i; j < s.Length; j++)
                {
                    if (!hashSet.Contains(s[j]))
                    {
                        hashSet.Add(s[j]);
                        currentMax++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentMax == expectedMax)
                {
                    return expectedMax;
                }
                actualMax = actualMax > currentMax ? actualMax : currentMax;
            }
            return actualMax;
        }

        /// <summary>
        /// 使用了Queue，参考：滑动窗口算法
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstringV3_Queue(string s)
        {
            int max = 0;
            Queue<char> queue = new Queue<char>();
            foreach (char c in s)
            {
                if (!queue.Contains(c))
                {
                    queue.Enqueue(c);
                }
                else
                {
                    max = max > queue.Count() ? max : queue.Count();
                    while (queue.Contains(c))
                    {
                        queue.Dequeue();
                    }
                    queue.Enqueue(c);
                }
            }
            max = max > queue.Count() ? max : queue.Count();
            return max;
        }
    }
}
