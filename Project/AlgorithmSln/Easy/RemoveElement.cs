using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Easy
{
    public static class RemoveElement
    {
        /// <summary>
        /// 27. Remove Element
        /// Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The relative order of the elements may be changed.
        /// Since it is impossible to change the length of the array in some languages, you must instead have the result be placed in the first part of the array nums.More formally, if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result.It does not matter what you leave beyond the first k elements.
        /// Return k after placing the final result in the first k slots of nums.
        /// Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static int RemoveElementFunc(this int[] nums, int val)
        {
            if (nums.Length == 0) return 0;
            int fast = -1;
            int slow = 0;
            int total = 0;
            while (++fast < nums.Length)
            {
                if (nums[fast] != val)
                {
                    nums[slow] = nums[fast];
                    slow++;
                    total++;
                }
            }
            return total;
        }
    }
}
