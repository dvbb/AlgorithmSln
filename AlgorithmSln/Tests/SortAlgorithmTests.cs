using AlgorithmSln;
using Common;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class SortAlgorithmTests
    {
        private SortAlgorithm member;
        [SetUp]
        public void Setup()
        {
            member = new SortAlgorithm();
        }

        [Test]
        public void BubbleSortTest()
        {
            int[] nums1 = { 2, 92, 15, 8 };
            int[] nums2 = { 3, 44, 38, 5,5,3,92,66 };
            string expected1 = "[2,8,15,92]";
            string expected2 = "[3,3,5,5,38,44,66,92]";
            Assert.IsTrue(MyFormat.Format(member.BubbleSort(nums1)) == expected1);
            Assert.IsTrue(MyFormat.Format(member.BubbleSort(nums2)) == expected2);
        }

        [Test]
        public void SelectSortTest()
        {
            int[] nums1 = { 2, 92, 15, 8 };
            int[] nums2 = { 3, 44, 38, 5, 5, 3, 92, 66 };
            string expected1 = "[2,8,15,92]";
            string expected2 = "[3,3,5,5,38,44,66,92]";
            Assert.IsTrue(MyFormat.Format(member.SelectionSort(nums1)) == expected1);
            Assert.IsTrue(MyFormat.Format(member.SelectionSort(nums2)) == expected2);
        }
    }
}
