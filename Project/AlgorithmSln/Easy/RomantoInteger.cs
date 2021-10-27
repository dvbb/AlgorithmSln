using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Easy
{
    public class RomantoInteger
    {
        /// <summary>
        /// Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int RomanToInt(string s)
        {
            int result = 0;
            #region V1: Replace special number(Use HashTable)
            //Hashtable table = new Hashtable()
            //{
            //    {"IV",4 },
            //    {"IX",9 },
            //    {"XL",40 },
            //    {"XC",90 },
            //    {"CD",400 },
            //    {"CM",900 },
            //};
            //foreach (string item in table.Keys)
            //{
            //    if (s.Contains(item))
            //    {
            //        s = s.Replace(item, "");
            //        result += (int)table[item];
            //    }
            //}
            #endregion

            // V2: Replace special number(Use Equivalent Exchange)
            s = s.Replace("IV", "a");
            s = s.Replace("IX", "b");
            s = s.Replace("XL", "c");
            s = s.Replace("XC", "d");
            s = s.Replace("CD", "e");
            s = s.Replace("CM", "f");

            for (int i = 0; i < s.Length; i++)
            {
                result += GetCharValue(s[i]);
            }
            return result;
        }

        public static int GetCharValue(char ch)
        {
            switch (ch)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                case 'a': return 4;
                case 'b': return 9;
                case 'c': return 40;
                case 'd': return 90;
                case 'e': return 400;
                case 'f': return 900;
                default: return 0;
            }
        }
    }
}
