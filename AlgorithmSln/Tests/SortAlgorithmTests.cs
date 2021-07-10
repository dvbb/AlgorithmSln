using AlgorithmSln;
using AlgorithmSln.Interface;
using Common;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class SortAlgorithmTests
    {
        private ISortAlgorithm _member;
        [SetUp]
        public void Setup()
        {
            _member = new SortAlgorithm();
        }

        [Test]
        public void BubbleSortTest()
        {
            int[] nums1 = { 2, 92, 15, 8 };
            int[] nums2 = { 3, 44, 38, 5,5,3,92,66 };
            string expected1 = "[2,8,15,92]";
            string expected2 = "[3,3,5,5,38,44,66,92]";
            Assert.IsTrue(MyFormat.Format(_member.BubbleSort(nums1)) == expected1);
            Assert.IsTrue(MyFormat.Format(_member.BubbleSort(nums2)) == expected2);
        }

        [Test]
        public void SelectionSortTest()
        {
            int[] nums1 = { 2, 92, 15, 8 };
            int[] nums2 = { 3, 44, 38, 5, 5, 3, 92, 66 };
            string expected1 = "[2,8,15,92]";
            string expected2 = "[3,3,5,5,38,44,66,92]";
            Assert.IsTrue(MyFormat.Format(_member.SelectionSort(nums1)) == expected1);
            Assert.IsTrue(MyFormat.Format(_member.SelectionSort(nums2)) == expected2);
        }

        [Test]
        public void InsertionSortTest()
        {
            int[] nums1 = { 2, 92, 15, 8 };
            int[] nums2 = { 3, 44, 38, 5, 5, 3, 92, 66 };
            string expected1 = "[2,8,15,92]";
            string expected2 = "[3,3,5,5,38,44,66,92]";
            Assert.IsTrue(MyFormat.Format(_member.InsertionSort(nums1)) == expected1);
            Assert.IsTrue(MyFormat.Format(_member.InsertionSort(nums2)) == expected2);
        }

        [Test]
        public void ShellSortTest()
        {
            int[] nums1 = { 2, 92, 15, 8 };
            int[] nums2 = { 3, 44, 38, 5, 5, 3, 92, 66 };
            string expected1 = "[2,8,15,92]";
            string expected2 = "[3,3,5,5,38,44,66,92]";
            Assert.IsTrue(MyFormat.Format(_member.ShellSort(nums1)) == expected1);
            Assert.IsTrue(MyFormat.Format(_member.ShellSort(nums2)) == expected2);
        }
    }
}
