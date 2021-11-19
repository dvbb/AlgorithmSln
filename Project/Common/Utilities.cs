using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public static class Utilities
    {
        public static void Swap<T>(ref T num1, ref T num2)
        {
            T temp = num1;
            num1 = num2;
            num2 = temp;
        }

        public static T[] CopyTo<T>(T[] array, int start, int end)
        {
            T[] result = new T[end - start];
            int j = 0;
            for (int i = start; i < end; i++)
            {
                result[j++] = array[i];
            }
            return result;
        }
    }
}
