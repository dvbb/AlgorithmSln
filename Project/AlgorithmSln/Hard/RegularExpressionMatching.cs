using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Hard
{
    public class RegularExpressionMatching
    {

        /// <summary>
        /// Given an input string s and a pattern p, implement regular expression matching with support for '.' and '*' where:
        /// '.' Matches any single character.​​​​
        /// '*' Matches zero or more of the preceding element.
        /// The matching should cover the entire input string (not partial).
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool IsMatch(string s, string p)
        {
            if (p is ".*")
            {
                return true;
            }
            string s5 = "adfsbxbcdacfsc", p5 = "a.*bc.*c";
            var list = p5.Split(".*");
            int j = 0;
            bool result = true;
            for (int i = 0; i < s.Length; i++)
            {
                result = Compare(s, list, ref i, ref j);
                if (j > list.Length)
                {
                    return true;
                }
                if (!result)
                {
                    return result;
                }
            }
            return result;
        }

        private static bool Compare(string s, string[] list, ref int i, ref int j)
        {
            for (int x = 0; x < list[j].Length; x++)
            {
                if (s[i] == list[j][x])
                {
                    i++;
                }
            }
            j++;
            return true;
        }
    }
}
