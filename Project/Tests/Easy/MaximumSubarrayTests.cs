using Algorithm.Easy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTests.Easy
{
    public class MaximumSubarrayTests
    {
        private MaximumSubarray _member;

        [SetUp]
        public void SetUp()
        {
            _member = new MaximumSubarray();
        }

        /// <summary>
        /// 1 <= nums.length <= 10^5
        /// -10^4 <= nums[i] <= 10^4
        /// </summary>
        [Test]
        public void MaxSubArrayTest()
        {
            int[] nums1 = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int[] nums2 = new int[] { 1 };
            int[] nums3 = new int[] { 5, 4, -1, 7, 8 };
            int[] nums4 = new int[] { -104, 104 };
            int[] nums5 = new int[] { 0, 5, -1, -104, 56, -2, -2, -2, 104, -104, -100 };
            int[] nums6 = new int[] { -2, -2, -1 };
            int[] nums7 = new int[] { 5, 9, 4 };
            int expected1 = 6;
            int expected2 = 1;
            int expected3 = 23;
            int expected4 = 104;
            int expected5 = 154;
            int expected6 = -1;
            int expected7 = 18;
            Assert.AreEqual(expected1, _member.MaxSubArray(nums1));
            Assert.AreEqual(expected2, _member.MaxSubArray(nums2));
            Assert.AreEqual(expected3, _member.MaxSubArray(nums3));
            Assert.AreEqual(expected4, _member.MaxSubArray(nums4));
            Assert.AreEqual(expected5, _member.MaxSubArray(nums5));
            Assert.AreEqual(expected6, _member.MaxSubArray(nums6));
            Assert.AreEqual(expected7, _member.MaxSubArray(nums7));
        }
    }
}
