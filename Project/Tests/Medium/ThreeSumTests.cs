using Algorithm.Medium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlorithmTests.Medium
{
    public class ThreeSumTests
    {
        private ThreeSum _member;

        [SetUp]
        public void SetUp()
        {
            _member = new ThreeSum();
        }

        /// <summary>
        /// 0 <= nums.length <= 3000
        /// -105 <= nums[i] <= 105
        /// </summary>
        [Test]
        public void GetThreeSum()
        {
            int[] num1 = new int[] { -1, 0, 1, 2, -1, -4 };
            int[] num2 = new int[] { };
            int[] num3 = new int[] { 0 };
            int[] num4 = new int[] { 105, -105, 0 };
            int[] num5 = new int[] { -1, 2, 0 };
            int[] num6 = new int[] { 9, -8, 7, -1, -1, -1, 0, 6 };
            int[] num7 = new int[] { 0, 0, 0 };
            int[] num8 = new int[] { 1, 0, -1 };
            List<IList<int>> expected1 = new List<IList<int>>() { new List<int>() { -1, 0, 1 },new List<int>() { -1, -1, 2 }  };
            List<IList<int>> expected2 = new List<IList<int>>() { };
            List<IList<int>> expected3 = new List<IList<int>>() { };
            List<IList<int>> expected4 = new List<IList<int>>() { new List<int>() { -105, 0, 105 } };
            List<IList<int>> expected5 = new List<IList<int>>() { };
            List<IList<int>> expected6 = new List<IList<int>>() { new List<int>() { -8, -1, 9 } };
            List<IList<int>> expected7 = new List<IList<int>>() { new List<int>() { 0, 0, 0 } };
            List<IList<int>> expected8 = new List<IList<int>>() { new List<int>() { -1, 0, 1 } };
            Assert.AreEqual(expected1, _member.GetThreeSum(num1));
            Assert.AreEqual(expected2, _member.GetThreeSum(num2));
            Assert.AreEqual(expected3, _member.GetThreeSum(num3));
            Assert.AreEqual(expected4, _member.GetThreeSum(num4));
            Assert.AreEqual(expected5, _member.GetThreeSum(num5));
            Assert.AreEqual(expected6, _member.GetThreeSum(num6));
            Assert.AreEqual(expected7, _member.GetThreeSum(num7));
            Assert.AreEqual(expected8, _member.GetThreeSum(num8));
        }

        [Test]
        public void GetThreeSumV2()
        {
            int[] num1 = new int[] { -1, 0, 1, 2, -1, -4 };
            int[] num2 = new int[] { };
            int[] num3 = new int[] { 0 };
            int[] num4 = new int[] { 105, -105, 0 };
            int[] num5 = new int[] { -1, 2, 0 };
            int[] num6 = new int[] { 9, -8, 7, -1, -1, -1, 0, 6 };
            int[] num7 = new int[] { 0, 0, 0 };
            int[] num8 = new int[] { 1, 0, -1 };
            List<IList<int>> expected1 = new List<IList<int>>() { new List<int>() { -1, -1, 2 }, new List<int>() { -1, 0, 1 } };
            List<IList<int>> expected2 = new List<IList<int>>() { };
            List<IList<int>> expected3 = new List<IList<int>>() { };
            List<IList<int>> expected4 = new List<IList<int>>() { new List<int>() { -105, 0, 105 } };
            List<IList<int>> expected5 = new List<IList<int>>() { };
            List<IList<int>> expected6 = new List<IList<int>>() { new List<int>() { -8, -1, 9 } };
            List<IList<int>> expected7 = new List<IList<int>>() { new List<int>() { 0, 0, 0 } };
            List<IList<int>> expected8 = new List<IList<int>>() { new List<int>() { -1, 0, 1 } };
            Assert.AreEqual(expected1, _member.GetThreeSumV2(num1));
            Assert.AreEqual(expected2, _member.GetThreeSumV2(num2));
            Assert.AreEqual(expected3, _member.GetThreeSumV2(num3));
            Assert.AreEqual(expected4, _member.GetThreeSumV2(num4));
            Assert.AreEqual(expected5, _member.GetThreeSumV2(num5));
            Assert.AreEqual(expected6, _member.GetThreeSumV2(num6));
            Assert.AreEqual(expected7, _member.GetThreeSumV2(num7));
            Assert.AreEqual(expected8, _member.GetThreeSumV2(num8));
        }
    }
}
