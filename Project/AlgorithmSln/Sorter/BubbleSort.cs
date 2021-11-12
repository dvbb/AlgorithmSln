using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Sorter
{
    public class BubbleSort
    {
        //Time Complexity: O(n²)
        //Time Complexity(average): O(n²)
        public int[] Sort(int[] nums)
        {
            int temp;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] > nums[i])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            return nums;
        }
    }
}
