using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public static class Utilities
    {
        public static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        public static int[] CopyArray(int[] array, int start, int end)
        {
            int[] result = new int[end - start];
            int j = 0;
            for (int i = start; i < end; i++)
            {
                result[j] = array[i];
                j++;
            }
            return result;
        }
    }
}
