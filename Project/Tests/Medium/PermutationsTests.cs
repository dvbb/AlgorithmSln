using Algorithm.Medium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlorithmTests.Medium
{
    public class PermutationsTests
    {
        private Permutations _member;

        [SetUp]
        public void SetUp()
        {
            _member = new Permutations();
        }

        /// <summary>
        /// 1 <= nums.length <= 6
        /// -10 <= nums[i] <= 10
        /// All the integers of nums are unique.
        /// </summary>
        [Test]
        public void PermuteTests()
        {
            int[] nums1 = new int[] { 1, 2, 3 };
            int[] nums2 = new int[] { 0, 1 };
            int[] nums3 = new int[] { 1 };
            IList<IList<int>> list1 = _member.Permute(nums1);
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
            //[[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
            //[[0,1],[1,0]]
            //[[1]]
        }
    }
}
