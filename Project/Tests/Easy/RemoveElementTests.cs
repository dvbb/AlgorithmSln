using Algorithm.Easy;
using Common;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlorithmTests.Easy
{
   public  class RemoveElementTests
    {
        [SetUp]
        public void SetUp()
        {
        }

        /// <summary>
        /// 0 <= nums.length <= 100
        /// 0 <= nums[i] <= 50
        /// 0 <= val <= 100
        /// </summary>
        [Test]
        public void RemoveElement()
        {
            int[] nums1 = new int[] { 3, 2, 2, 3 }; //del: 3
            int[] expectedNums1 = new int[] { 2, 2 };
            int expected1 = 2;

            int[] nums2 = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }; //del: 2
            int[] expectedNums2 = new int[] { 0, 1, 3, 0, 4 };
            int expected2 = 5;

            int[] nums3 = new int[] { }; //del: 0
            int[] expectedNums3 = new int[] { };
            int expected3 = 0;

            int[] nums4 = new int[] { 0,50,25,0}; //del: 0
            int[] expectedNums4 = new int[] {50,25 };
            int expected4 = 2;

            int[] nums5 = new int[] { 0, 50, 25, 0 }; //del: 100
            int[] expectedNums5 = new int[] { 0, 50, 25, 0 };
            int expected5 = 4;

            Assert.AreEqual(expected1,nums1.RemoveElementFunc(3));
            Assert.AreEqual(MyFormat.Convert(expectedNums1),MyFormat.Convert(nums1,expected1));
            Assert.AreEqual(expected2, nums2.RemoveElementFunc(2));
            Assert.AreEqual(MyFormat.Convert(expectedNums2), MyFormat.Convert(nums2, expected2));
            Assert.AreEqual(expected3, nums3.RemoveElementFunc(0));
            Assert.AreEqual(MyFormat.Convert(expectedNums3), MyFormat.Convert(nums3, expected3));
            Assert.AreEqual(expected4, nums4.RemoveElementFunc(0));
            Assert.AreEqual(MyFormat.Convert(expectedNums4), MyFormat.Convert(nums4, expected4));
            Assert.AreEqual(expected5, nums5.RemoveElementFunc(100));
            Assert.AreEqual(MyFormat.Convert(expectedNums5), MyFormat.Convert(nums5, expected5));
        }
    }
}
