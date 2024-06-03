using Algorithm.Easy;
using Common;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlorithmTests.Easy
{
    public class RemoveDuplicatesFromSortedArrayTests
    {
        private RemoveDuplicatesFromSortedArray _member;

        [SetUp]
        public void SetUp()
        {
            _member = new RemoveDuplicatesFromSortedArray();
        }

        /// <summary>
        /// 0 <= nums.length <= 3 * 104
        /// -100 <= nums[i] <= 100
        /// nums is sorted in non-decreasing order.
        /// </summary>
        [Test]
        public void RemoveDuplicates()
        {
            int[] nums1 = new int[] { 1, 1, 2 };
            int expected1 = 2;
            int[] expectedNums1 = new int[] { 1, 2 };

            int[] nums2 = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int expected2 = 5;
            int[] expectedNums2 = new int[] { 0, 1, 2, 3, 4 };

            int[] nums3 = new int[] { };
            int expected3 = 0;
            int[] expectedNums3 = new int[] { };

            int[] nums4 = new int[] { 1 };
            int expected4 = 1;
            int[] expectedNums4 = new int[] { 1 };

            int[] nums5 = new int[] { -100, -56, -56, -21, -12, 0, 0, 0, 2, 2, 8, 15, 15, 26, 26, 26, 52, 99, 99, 99, 100 };
            int expected5 = 12;
            int[] expectedNums5 = new int[] { -100, -56, -21, -12, 0, 2, 8, 15, 26, 52, 99, 100 };

            Assert.AreEqual(expected1, _member.RemoveDuplicates(nums1));
            Assert.AreEqual(expected2, _member.RemoveDuplicates(nums2));
            Assert.AreEqual(expected3, _member.RemoveDuplicates(nums3));
            Assert.AreEqual(expected4, _member.RemoveDuplicates(nums4));
            Assert.AreEqual(expected5, _member.RemoveDuplicates(nums5));

            Assert.AreEqual(expected1, _member.RemoveDuplicatesV2(nums1));
            Assert.AreEqual(expected2, _member.RemoveDuplicatesV2(nums2));
            Assert.AreEqual(expected3, _member.RemoveDuplicatesV2(nums3));
            Assert.AreEqual(expected4, _member.RemoveDuplicatesV2(nums4));
            Assert.AreEqual(expected5, _member.RemoveDuplicatesV2(nums5));
        }
    }
}
