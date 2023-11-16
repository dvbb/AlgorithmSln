using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Easy
{
    public class LongestCommonPrefix
    {
        /// <summary>
        /// Write a function to find the longest common prefix string amongst an array of strings.
        /// If there is no common prefix, return an empty string "".
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public string GetLongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1 || strs[0] == "")
            {
                return strs[0];
            }
            // 取最小的str为prefix
            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                if (strs[i] == "")
                {
                    return "";
                }
                prefix = prefix.Length > strs[i].Length ? strs[i] : prefix;
            }
            for (int i = 0; i < strs.Length; i++)
            {
                int j = 0;
                while (j < strs[i].Length && j < prefix.Length)
                {

                    prefix = prefix[j] == strs[i][j] ? prefix : prefix.Substring(0, j);
                    j++;
                }
            }
            return prefix;
        }
    }
}
