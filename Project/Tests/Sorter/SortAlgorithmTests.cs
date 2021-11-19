using Algorithm.Sorter;
using AlgorithmSln;
using AlgorithmSln.Interface;
using Common;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTests.sorter
{
    public class SortAlgorithmTests
    {
        //private ISortAlgorithm _member;
        private BubbleSort bubbleSort;
        private SelectionSort selectionSort;
        private InsertionSort insertionSort;
        private ShellSort shellSort;
        private MergeSort mergeSort;

        private static int[] nums1 = { 2, 92, 15, 8 };
        private static int[] nums2 = { 3, 44, 38, 5, 5, 3, 92, 66 };
        private static string expected1 = "[2,8,15,92]";
        private static string expected2 = "[3,3,5,5,38,44,66,92]";
        [SetUp]
        public void Setup()
        {
            bubbleSort = new BubbleSort();
            selectionSort = new SelectionSort();
            insertionSort = new InsertionSort();
            selectionSort = new SelectionSort();
            shellSort = new ShellSort();
            mergeSort = new MergeSort();
        }

        [Test]
        public void BubbleSortTest()
        {
            Assert.AreEqual(MyFormat.Convert(bubbleSort.Sort(nums1)), expected1);
            Assert.AreEqual(MyFormat.Convert(bubbleSort.Sort(nums2)), expected2);
        }

        [Test]
        public void SelectionSortTest()
        {
            Assert.AreEqual(MyFormat.Convert(selectionSort.Sort(nums1)), expected1);
            Assert.AreEqual(MyFormat.Convert(selectionSort.Sort(nums2)), expected2);
        }

        [Test]
        public void InsertionSortTest()
        {
            Assert.AreEqual(MyFormat.Convert(insertionSort.Sort(nums1)), expected1);
            Assert.AreEqual(MyFormat.Convert(insertionSort.Sort(nums2)), expected2);
        }

        [Test]
        public void ShellSortTest()
        {
            Assert.AreEqual(MyFormat.Convert(shellSort.Sort(nums1)), expected1);
            Assert.AreEqual(MyFormat.Convert(shellSort.Sort(nums2)), expected2);
        }

        [Test]
        public void MergeSortTest()
        {
            Assert.AreEqual(MyFormat.Convert(mergeSort.Sort(nums1)), expected1);
            Assert.AreEqual(MyFormat.Convert(mergeSort.Sort(nums2)), expected2);
        }
    }
}
