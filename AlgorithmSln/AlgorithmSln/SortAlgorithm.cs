using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSln
{
    public class SortAlgorithm
    {
        public int[] BubbleSort(int[] nums)
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
