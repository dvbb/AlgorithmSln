using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Eazy
{
    public class ValidParentheses
    {
        /// <summary>
        /// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        /// An input string is valid if:
        /// 1.Open brackets must be closed by the same type of brackets.
        /// 2.Open brackets must be closed in the correct order.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsValid_ByStack(string str)
        {
            if (str.Length % 2 != 0)
            {
                return false;
            }
            Stack<char> stack = new Stack<char>();
            foreach (char ch in str)
            {
                if (ch is '(' || ch is '[' || ch is '{')
                {
                    stack.Push(ch);
                    continue;
                }
                if ((ch is ')' || ch is ']' || ch is '}') && stack.Count == 0)
                {
                    return false;
                }
                if (ch is ')')
                {
                    if (stack.Pop() != '(')
                    {
                        return false;
                    }
                }
                if (ch is ']')
                {
                    if (stack.Pop() != '[')
                    {
                        return false;
                    }
                }
                if (ch is '}')
                {
                    if (stack.Pop() != '{')
                    {
                        return false;
                    }
                }
            }
            if (stack.Count == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// time cost and space cost are close to V1.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsValid_ByStackV2(string s)
        {
            Dictionary<char, char> dic = new Dictionary<char, char>
            {
                { ']', '[' },
                { ')', '(' },
                { '}', '{' },
            };
            var stack = new Stack<char>();
            foreach (var c in s)
            {
                if (dic.ContainsKey(c))
                {
                    if (stack.Count == 0) return false;
                    if (stack.Pop() != dic[c]) return false;
                }
                else
                    stack.Push(c);
            }
            return stack.Count == 0 ? true : false;
        }

        /// <summary>
        /// time cost and space cost is highest
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsValid_ByReplace(string s)
        {
            while(s.Contains("()")|| s.Contains("[]")|| s.Contains("{}"))
            {
                s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
            }
            if (s is "")
            {
                return true;
            }
            return false;
        }
    }
}
