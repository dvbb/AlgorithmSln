using AlgorithmSln;
using System;
using System.Collections.Generic;
using System.Text;
using Common;
using NUnit.Framework;
using AlgorithmSln.Interface;

namespace Tests
{
    public class SumOfTwoNumbersTests
    {
        private  ISumOfTwoNumbers _member;

        [SetUp]
        public void Setup()
        {
            _member = new SumOfTwoNumbers();
        }

        [Test]
        public void TwoSumTest()
        {
            int[] nums1 = { 2, 7, 11, 15 };
            int[] nums2 = { 3, 2, 4 };
            int[] nums3 = { 3, 3 };
            int[] nums4 = { 3, 5,5,3 };
            string expected1 = "[0,1]";
            string expected2 = "[1,2]";
            string expected3 = "[0,1]";
            string expected4 = "[0,3]";
            Assert.IsTrue(MyFormat.Format(_member.TwoSum(nums1, 9)) == expected1);
            Assert.IsTrue(MyFormat.Format(_member.TwoSum(nums2, 6)) == expected2);
            Assert.IsTrue(MyFormat.Format(_member.TwoSum(nums3, 6)) == expected3);
            Assert.IsTrue(MyFormat.Format(_member.TwoSum(nums4, 6)) == expected4);
        }
    }
}