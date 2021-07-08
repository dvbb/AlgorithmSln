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
        public void BubbleSort()
        {
            int[] nums1 = { 2, 92, 15, 8 };
            string expected1 = "[2,8,15,92]";
            Assert.IsTrue(MyFormat.Format(member.BubbleSort(nums1)) == expected1);
        }
    }
}
