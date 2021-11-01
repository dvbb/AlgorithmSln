using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Medium
{
    public class ThreeSumClosest
    {
        /// <summary>
        /// Given an integer array nums of length n and an integer target, find three integers in nums such that the sum is closest to target.
        /// Return the sum of the three integers.
        /// You may assume that each input would have exactly one solution.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int GetThreeSumClosest(int[] nums, int target)
        {
            int result = nums[0] + nums[1] + nums[2];
            int diff;
            Array.Sort(nums);
            for (int i = 1; i < nums.Length-1; i++)
            {
                int left = i - 1;
                int right = i + 1;
                while (left >= 0 && right < nums.Length)
                {
                    diff = target - (nums[i] + nums[left] + nums[right]);
                    result = Math.Abs( target - result) < Math.Abs( diff) ? result : nums[i] + nums[left] + nums[right];
                    if (diff == 0) break;
                    if (diff > 0) right++;
                    if (diff < 0) left--;
                }
            }
            return result;
        }
    }
}
