using Common;
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

        //Each cycle select the smallest item , and place it at the nums[i]
        public int[] SelectionSort(int[] nums)
        {
            int min,count;
            for (int i = 0; i < nums.Length; i++)
            {
                min = nums[i];
                count = i;
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[j]<min)
                    {
                        count = j;
                        min = nums[j];
                    }
                }
                Utilities.Swap(ref nums[i], ref nums[count]);
            }
            return nums;
        }

        public int[] InsertionSort(int[] nums)
        {
            return nums;
        }

        public int[] ShellSort(int[] nums)
        {
            return nums;
        }

        public int[] MergeSort(int[] nums)
        {
            return nums;
        }

        public int[] QuickSort(int[] nums)
        {
            return nums;
        }

        public int[] HeapSort(int[] nums)
        {
            return nums;
        }

        public int[] CountingSort(int[] nums)
        {
            return nums;
        }

        public int[] BucketSort(int[] nums)
        {
            return nums;
        }

        public int[] RadixSort(int[] nums)
        {
            return nums;
        }
    }
}
