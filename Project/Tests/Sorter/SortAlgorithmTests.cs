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
        private ISortAlgorithm _member;
        private BubbleSort bubbleSort;
        private SelectionSort selectionSort;
        private InsertionSort insertionSort;
        private ShellSort shellSort;
        private MergeSort mergeSort;
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
            int[] nums1 = { 2, 92, 15, 8 };
            int[] nums2 = { 3, 44, 38, 5, 5, 3, 92, 66 };
            string expected1 = "[2,8,15,92]";
            string expected2 = "[3,3,5,5,38,44,66,92]";
            Assert.AreEqual(MyFormat.Format(bubbleSort.Sort(nums1)), expected1);
            Assert.AreEqual(MyFormat.Format(bubbleSort.Sort(nums2)), expected2);
        }

        [Test]
        public void SelectionSortTest()
        {
            int[] nums1 = { 2, 92, 15, 8 };
            int[] nums2 = { 3, 44, 38, 5, 5, 3, 92, 66 };
            string expected1 = "[2,8,15,92]";
            string expected2 = "[3,3,5,5,38,44,66,92]";
            Assert.AreEqual(MyFormat.Format(selectionSort.Sort(nums1)), expected1);
            Assert.AreEqual(MyFormat.Format(selectionSort.Sort(nums2)), expected2);
        }

        [Test]
        public void InsertionSortTest()
        {
            int[] nums1 = { 2, 92, 15, 8 };
            int[] nums2 = { 3, 44, 38, 5, 5, 3, 92, 66 };
            string expected1 = "[2,8,15,92]";
            string expected2 = "[3,3,5,5,38,44,66,92]";
            Assert.AreEqual(MyFormat.Format(insertionSort.Sort(nums1)), expected1);
            Assert.AreEqual(MyFormat.Format(insertionSort.Sort(nums2)), expected2);
        }

        [Test]
        public void ShellSortTest()
        {
            int[] nums1 = { 2, 92, 15, 8 };
            int[] nums2 = { 3, 44, 38, 5, 5, 3, 92, 66 };
            string expected1 = "[2,8,15,92]";
            string expected2 = "[3,3,5,5,38,44,66,92]";
            Assert.AreEqual(MyFormat.Format(shellSort.Sort(nums1)), expected1);
            Assert.AreEqual(MyFormat.Format(shellSort.Sort(nums2)), expected2);
        }

        [Test]
        public void MergeSortTest()
        {
            int[] nums1 = { 2, 92, 15, 8 };
            int[] nums2 = { 3, 44, 38, 5, 5, 3, 92, 66 };
            string expected1 = "[2,8,15,92]";
            string expected2 = "[3,3,5,5,38,44,66,92]";
            Assert.AreEqual(MyFormat.Format(mergeSort.Sort(nums1)), expected1);
            Assert.AreEqual(MyFormat.Format(mergeSort.Sort(nums2)), expected2);
        }
    }
}
