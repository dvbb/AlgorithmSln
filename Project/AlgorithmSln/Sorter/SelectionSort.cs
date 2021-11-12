using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Sorter
{
    public class SelectionSort
    {
        //Each cycle select the smallest item , and place it at the nums[i]
        //Time Complexity: O(n²)
        //Time Complexity(average): O(n²)
        public int[] Sort(int[] nums)
        {
            int min, count;
            for (int i = 0; i < nums.Length; i++)
            {
                min = nums[i];
                count = i;
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[j] < min)
                    {
                        count = j;
                        min = nums[j];
                    }
                }
                Utilities.Swap(ref nums[i], ref nums[count]);
            }
            return nums;
        }
    }
}
