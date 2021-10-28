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
            string prefix = strs[0];
            if (strs.Length == 1)
            {
                return prefix;
            }
            for (int i = 1; i < strs.Length; i++)
            {
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
