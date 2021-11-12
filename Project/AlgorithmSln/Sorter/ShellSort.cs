using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Sorter
{
    public class ShellSort
    {
        //Same as InsertionSort, except that the number of sorts is reduced
        //Time Complexity: O(n²)
        //Time Complexity(average): O(n¹ ³)
        public int[] Sort(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums;
            }
            int pre, cur;
            for (int gap = nums.Length / 2; gap > 0; gap = gap / 2)
            {
                for (int i = gap; i < nums.Length; i++)
                {
                    pre = i - 1;
                    cur = nums[i];
                    while (nums[pre] > cur && pre > 0)
                    {
                        nums[pre + 1] = nums[pre];
                        pre--;
                    }
                    nums[pre + 1] = cur;
                }
            }
            return nums;
        }
    }
}
