using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Sorter
{
    public class MergeSort
    {
        //Time Complexity: O(n㏒₂ⁿ)
        //Time Complexity(average): O(n㏒₂ⁿ)
        public int[] Sort(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums;
            }
            int[] left = Utilities.CopyArray(nums, 0, nums.Length / 2);
            int[] right = Utilities.CopyArray(nums, nums.Length / 2, nums.Length);
            return Merge(Sort(left), Sort(right));
        }
        public int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int i = 0;
            int j = 0;
            int count = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] > right[j])
                {
                    result[count] = right[j];
                    j++;
                    count++;
                }
                else
                {
                    result[count] = left[i];
                    i++;
                    count++;
                }
            }
            while (i < left.Length)
            {
                result[count] = left[i];
                i++;
                count++;
            }
            while (j < right.Length)
            {
                result[count] = right[j];
                j++;
                count++;
            }
            return result;
        }
    }
}
