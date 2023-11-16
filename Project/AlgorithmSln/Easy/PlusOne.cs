using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Easy
{
    public class PlusOne
    {
        public int[] Plus(int[] digits)
        {
            if (digits.Length == 0)
                throw new ArgumentNullException("Digits cannot be null or empty.");

            int last = digits.Length - 1;
            if (digits[last] != 9)
            {
                digits[last] = digits[last] + 1;
                return digits;
            }
            while (last >= 1 && digits[--last] == 9) ;
            if (last == 0 && digits[last] == 9)
            {
                int[] result = new int[digits.Length + 1];
                result[0] = 1;
                return result;
            }
            else
            {
                for (int i = last + 1; i < digits.Length; i++)
                {
                    digits[i] = 0;
                }
                digits[last] = digits[last] + 1;
                return digits;
            }
        }

        public int[] PlusV2(int[] digits)
        {
            //处理普通情况
            int last = digits.Length - 1;
            if (digits[last] != 9)
            {
                digits[last]++;
                return digits;
            }

            // 9则置零，继续向前遍历，非9则+1，返回结果
            for (int i = last; i >= 0; i--)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i]++;
                    return digits;
                }
            }
            // 遍历结束，digits只包含9，返回一个新数组
            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }
    }
}
