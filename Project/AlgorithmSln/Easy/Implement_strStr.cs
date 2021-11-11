using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Easy
{
    public class Implement_strStr
    {
        /// <summary>
        /// Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public int StrStr(string haystack, string needle)
        {
            if (needle == "") return 0;
            if (needle != "" && haystack == "") return -1;
            if (!haystack.Contains(needle)) return -1;
            return haystack.IndexOf(needle);
        }

        #region KMP Alogorithm
        /// <summary>
        /// ref: https://leetcode-cn.com/problems/implement-strstr/solution/c-kmp-xi-wang-wo-jiang-ming-bai-liao-kmpsuan-fa-by/
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public int StrStrV2(string haystack, string needle)
        {
            if (needle == "") return 0;
            if (needle != "" && haystack == "") return -1;
            return KMP(haystack, needle);
        }
        private int KMP(string haystack, string needle)
        {
            int[] next = GetNext(needle);
            int i = 0;
            int j = 0;
            while (i < haystack.Length)
            {
                if (haystack[i] == needle[j])
                {
                    j++;
                    i++;
                }
                if (j == needle.Length)
                {
                    return i - j;
                }
                else if (i < haystack.Length && haystack[i] != needle[j])
                {
                    if (j != 0)
                        j = next[j - 1];
                    else
                        i++;
                }

            }
            return -1;
        }
        private int[] GetNext(string str)
        {
            int[] next = new int[str.Length];
            next[0] = 0;
            int i = 1;
            int j = 0;
            while (i < str.Length)
            {
                if (str[i] == str[j])
                {
                    j++;
                    next[i] = j;
                    i++;
                }
                else
                {
                    if (j == 0)
                    {
                        next[i] = 0;
                        i++;
                    }
                    else
                    {
                        j = next[j - 1];
                    }
                }
            }
            return next;
        }
        #endregion
    }
}
