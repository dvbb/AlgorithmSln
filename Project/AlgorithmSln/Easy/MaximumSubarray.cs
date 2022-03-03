using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Easy
{
    public class MaximumSubarray
    {
        /// <summary>
        /// Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
        /// A subarray is a contiguous part of an array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0)
                throw new ArgumentNullException("Input Array Cannot Be Null Or Empty");
            if (nums.Length == 1)
                return nums[0];

            int max = nums[0];
            int sum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > sum + nums[i])
                {
                    sum = nums[i];
                }
                else 
                {
                    sum += nums[i];
                }
                max = max > sum ? max : sum;
            }
            return max;
        }
    }
}
