using Algorithm.Medium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlorithmTests.Medium
{
    public class ThreeSumClosestTests
    {
        private ThreeSumClosest _member;

        [SetUp]
        public void SetUp()
        {
            _member = new ThreeSumClosest();
        }

        /// <summary>
        /// 3 <= nums.length <= 1000
        /// -1000 <= nums[i] <= 1000
        /// -104 <= target <= 104
        /// </summary>
        [Test]
        public void GetThreeSumClosest()
        {
            int[] nums1 = new int[] { -1, 2, 1, -4 };
            int[] nums2 = new int[] { 0, 0, 0 };
            int[] nums3 = new int[] { -1000, 1000, -1, 2, 1, 1 };
            int[] nums4 = new int[] { 99, 10, -7, 0, 6 };
            int[] nums5 = new int[] { 99, 10, -7, 0, 6 };
            int[] nums6 = new int[] { 104, 0, 1, 0, 1,30 ,-12,-99,999};
            int[] nums7 = new int[] { 1, 2, 5, 10, 11 };
            Assert.AreEqual(2, _member.GetThreeSumClosest(nums1, 1));
            Assert.AreEqual(0, _member.GetThreeSumClosest(nums2, 1));
            Assert.AreEqual(1, _member.GetThreeSumClosest(nums3, 1));
            Assert.AreEqual(-1, _member.GetThreeSumClosest(nums4, -104));
            Assert.AreEqual(105, _member.GetThreeSumClosest(nums5, 104));
            Assert.AreEqual(35, _member.GetThreeSumClosest(nums6, 56));
            Assert.AreEqual(13, _member.GetThreeSumClosest(nums7, 12));
        }
    }
}
