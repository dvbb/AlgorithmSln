﻿using AlgorithmSln.Interface;
using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSln
{
    public class SortAlgorithm: ISortAlgorithm
    {
        //Time Complexity: O(n²)
        //Time Complexity(average): O(n²)
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
        //Time Complexity: O(n²)
        //Time Complexity(average): O(n²)
        public int[] SelectionSort(int[] nums)
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

        //Sort the nums[i] each time through the loop
        //Time Complexity: O(n²)
        //Time Complexity(average): O(n²)
        public int[] InsertionSort(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums;
            }
            int pre, cur;
            for (int i = 1; i < nums.Length; i++)
            {
                pre = i - 1;
                cur = nums[i];
                while (nums[pre] > cur && pre > 0)
                {
                    nums[pre+1] = nums[pre];
                    pre--;
                }
                nums[pre + 1] = cur;
            }
            return nums;
        }

        //Same as InsertionSort, except that the number of sorts is reduced
        //Time Complexity: O(n²)
        //Time Complexity(average): O(n¹ ³)
        public int[] ShellSort(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums;
            }
            int pre, cur;
            for (int gap = nums.Length/2; gap>0; gap=gap/2)
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

        //Time Complexity: O(n²)
        //Time Complexity(average): O(n²)
        public int[] MergeSort(int[] nums)
        {
            return nums;
        }

        //Time Complexity: O(n²)
        //Time Complexity(average): O(n²)
        public int[] QuickSort(int[] nums)
        {
            return nums;
        }

        //Time Complexity: O(n²)
        //Time Complexity(average): O(n²)
        public int[] HeapSort(int[] nums)
        {
            return nums;
        }

        //Time Complexity: O(n²)
        //Time Complexity(average): O(n²)
        public int[] CountingSort(int[] nums)
        {
            return nums;
        }

        //Time Complexity: O(n²)
        //Time Complexity(average): O(n²)
        public int[] BucketSort(int[] nums)
        {
            return nums;
        }

        //Time Complexity: O(n²)
        //Time Complexity(average): O(n²)
        public int[] RadixSort(int[] nums)
        {
            return nums;
        }
    }
}
