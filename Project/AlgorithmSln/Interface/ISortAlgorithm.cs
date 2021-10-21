using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSln.Interface
{
    public interface ISortAlgorithm
    {
        int[] BubbleSort(int[] nums);
        int[] SelectionSort(int[] nums);
        int[] InsertionSort(int[] nums);
        int[] ShellSort(int[] nums);
        int[] MergeSort(int[] nums);
        int[] QuickSort(int[] nums);
        int[] HeapSort(int[] nums);
        int[] CountingSort(int[] nums);
        int[] BucketSort(int[] nums);
        int[] RadixSort(int[] nums);
    }
}
