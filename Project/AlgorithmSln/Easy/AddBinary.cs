using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Easy
{
    public class AddBinary
    {
        /// <summary>
        /// 72ms    defeat 84.58%
        /// 39.41MB defeat 31.34%
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string AddBinaryMethod(string a, string b)
        {
            if (a == "")
                return b;
            if (b == "")
                return a;
            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;
            string result = "";
            while (i >= 0 || j >= 0 || carry > 0)
            {
                int digit1 = i >= 0 ? a[i] - '0' : 0;
                int digit2 = j >= 0 ? b[j] - '0' : 0;
                int sum = digit1 + digit2 + carry;
                carry = sum >= 2 ? 1 : 0;
                result = (sum % 2).ToString() + result;
                i--;
                j--;
            }
            return result;
        }
    }
}
