using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Easy
{
    public class RemoveDuplicatesFromSortedArray
    {
        /// <summary>
        /// 26. Remove Duplicates from Sorted Array
        /// Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once.
        /// The relative order of the elements should be kept the same.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return 1;
            int total = 1;
            int temp = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[temp])
                {
                    nums[temp + 1] = nums[i];
                    temp++;
                    total++;
                }
            }
            return total;
        }
    }
}
