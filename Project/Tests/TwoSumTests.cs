using AlgorithmSln;
using System;
using System.Collections.Generic;
using System.Text;
using Common;
using NUnit.Framework;
using AlgorithmSln.Interface;

namespace AlgorithmTests
{
    public class TwoSumTests
    {
        private ISumOfTwoNumbers _member;

        [SetUp]
        public void Setup()
        {
            _member = new TwoSum();
        }

        [Test]
        public void TwoSumTest()
        {
            int[] nums1 = { 2, 7, 11, 15 };
            int[] nums2 = { 3, 2, 4 };
            int[] nums3 = { 3, 3 };
            int[] nums4 = { 3, 5, 5, 3 };
            string expected1 = "[0,1]";
            string expected2 = "[1,2]";
            string expected3 = "[0,1]";
            string expected4 = "[0,3]";
            Assert.AreEqual(MyFormat.Format(_member.TwoSumAdd(nums1, 9)), expected1);
            Assert.AreEqual(MyFormat.Format(_member.TwoSumAdd(nums2, 6)), expected2);
            Assert.AreEqual(MyFormat.Format(_member.TwoSumAdd(nums3, 6)), expected3);
            Assert.AreEqual(MyFormat.Format(_member.TwoSumAdd(nums4, 6)), expected4);
        }                                                 
    }
}