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

        public int StrStrV2(string haystack, string needle)
        {
            if (needle == "") return 0;
            if (needle != "" && haystack == "") return -1;
            if (!haystack.Contains(needle)) return -1;
            return haystack.IndexOf(needle);
        }
    }
}
