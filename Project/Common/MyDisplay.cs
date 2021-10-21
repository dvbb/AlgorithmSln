﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public static class MyDisplay
    {
        public static void Show(int[] nums)
        {
            string result = "[";
            for (int i = 0; i < nums.Length-1; i++)
            {
                result += nums[i] + ",";
            }
            result += nums[nums.Length-1] +"]";
            Console.WriteLine(result);
        }
    }
}