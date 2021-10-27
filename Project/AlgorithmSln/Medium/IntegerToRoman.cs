using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Medium
{
    public class IntegerToRoman
    {
        public string IntToRoman(int num)
        {
            string result = "";
            int count = 10;
            while (num != 0)
            {
                int temp = num % count;
                if (temp > 0)
                {
                    if (count == 10)
                    {
                        result = ChangeRemainderToString(temp, "I", "V", "X") + result;
                    }
                    if (count == 100)
                    {
                        result = ChangeRemainderToString(temp / 10, "X", "L", "C") + result;
                    }
                    if (count == 1000)
                    {
                        result = ChangeRemainderToString(temp / 100, "C", "D", "M") + result;
                    }
                    if (count == 10000)
                    {
                        result = ChangeRemainderToString(temp / 1000, "M", "*", "*") + result;
                    }
                }
                num -= temp;
                count *= 10;
            }
            return result;
        }

        public static string ChangeRemainderToString(int num, string one, string five, string ten)
        {
            string result = "";
            switch (num)
            {
                case 1:
                    result = one;
                    break;
                case 2:
                    result = one + one;
                    break;
                case 3:
                    result = one + one + one;
                    break;
                case 4:
                    result = one + five;
                    break;
                case 5:
                    result = five;
                    break;
                case 6:
                    result = five + one;
                    break;
                case 7:
                    result = five + one + one;
                    break;
                case 8:
                    result = five + one + one + one;
                    break;
                case 9:
                    result = one + ten;
                    break;
            }
            return result;
        }
    }
}
