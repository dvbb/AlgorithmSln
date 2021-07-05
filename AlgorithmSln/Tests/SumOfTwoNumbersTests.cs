using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmSln;
using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace Tests
{
    [TestClass()]
    public class SumOfTwoNumbersTests
    {
        public SumOfTwoNumbers member = new SumOfTwoNumbers();

        [TestMethod()]
        public void TwoSumTest()
        {
            int[] nums1 = { 2, 7, 11, 15 };
            int[] nums2 = { 3, 2, 4 };
            int[] nums3 = { 3, 3 };
            string expected1 = "[0,1]";
            string expected2 = "[1,2]";
            string expected3 = "[0,1]";
            Assert.IsTrue(MyFormat.Format(member.TwoSum(nums1, 9)) == expected1);
            Assert.IsTrue(MyFormat.Format(member.TwoSum(nums2, 6)) == expected2);
            //Assert.IsTrue(MyFormat.Format(member.TwoSum(nums3, 6)) == expected3);
        }
    }
}