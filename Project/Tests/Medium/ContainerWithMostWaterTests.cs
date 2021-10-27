using Algorithm.Medium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlorithmTests.Medium
{
    public class ContainerWithMostWaterTests
    {
        ContainerWithMostWater _member;

        [SetUp]
        public void SetUp()
        {
            _member = new ContainerWithMostWater();
        }

        /// <summary>
        /// n == height.length
        /// 2 <= n <= 105
        /// 0 <= height[i] <= 104
        /// </summary>
        [Test]
        public void MaxArea()
        {
            int[] height1 = new int[] { 1,8,6,2,5,4,8,3,7  };
            int[] height2 = new int[] { 1, 1 };
            int[] height3 = new int[] { 4, 3, 2, 1, 4 };
            int[] height4 = new int[] { 1, 2, 1 };
            int[] height5 = new int[] { 0, 0 };
            int[] height6 = new int[] { 10, 0 ,10};
            Assert.AreEqual(49,_member.MaxArea(height1));
            Assert.AreEqual(1,_member.MaxArea(height2));
            Assert.AreEqual(16,_member.MaxArea(height3));
            Assert.AreEqual(2,_member.MaxArea(height4));
            Assert.AreEqual(0,_member.MaxArea(height5));
            Assert.AreEqual(20,_member.MaxArea(height6));
        }
    }
}
