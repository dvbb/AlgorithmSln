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
            while ( last >= 1&& digits[--last] == 9) ;
            if (last == 0 && digits[last] == 9)
            {
                int[] result = new int[digits.Length + 1];
                result[0] = 1;
                return result;
            }
            else
            {
                for (int i = last+1; i < digits.Length; i++)
                {
                    digits[i] = 0;
                }
                digits[last] = digits[last] + 1;
                return digits;
            }
        }
    }
}
