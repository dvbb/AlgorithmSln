using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Sorter
{
    public class InsertionSort
    {
        //Sort the nums[i] each time through the loop
        //Time Complexity: O(n²)
        //Time Complexity(average): O(n²)
        public int[] Sort(int[] nums)
        {
            if (nums.Length == 1) return nums;
            int pre, cur;
            for (int i = 1; i < nums.Length; i++)
            {
                pre = i ;
                cur = nums[i];
                while (nums[--pre] > cur && pre > 0)
                {
                    nums[pre + 1] = nums[pre];
                }
                nums[pre + 1] = cur;
            }
            return nums;
        }
    }
}
