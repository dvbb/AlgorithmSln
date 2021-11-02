using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Medium
{
    public class LetterCombinations
    {
        /// <summary>
        /// Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.
        /// Mapping:
        ///     2:abc 3:def 4:ghi 5:jkl 6:mno 7:pqrs 8:tuv 9:wxyz
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public IList<string> GetLetterCombinations(string digits)
        {
            if (digits.Length == 0)
            {
                return new List<string>();
            }
            return GetATree(new List<string>(), digits, 0);
        }

        public List<String> GetATree(List<String> list, string digits, int i)
        {
            if (i == digits.Length)
            {
                return list;
            }
            string str = GetMapping(digits[i]);
            if (list.Count == 0)
            {
                for (int cur = 0; cur < str.Length; cur++)
                {
                    list.Add(str[cur].ToString());
                }
                return GetATree(list, digits, i + 1);
            }
            else
            {
                List<string> addonsList = new List<string>();
                foreach (var item in list)
                {
                    for (int cur = 0; cur < str.Length; cur++)
                    {
                        addonsList.Add(item + str[cur].ToString());
                    }
                }
                return GetATree(addonsList, digits, i + 1);
            }
        }

        public string GetMapping(char num)
        {
            switch (num)
            {
                case '2': return "abc";
                case '3': return "def";
                case '4': return "ghi";
                case '5': return "jkl";
                case '6': return "mno";
                case '7': return "pqrs";
                case '8': return "tuv";
                case '9': return "wxyz";
                default: return "";
            }
        }
    }
}
