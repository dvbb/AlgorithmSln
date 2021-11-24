using Algorithm.Medium;
using Common;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlorithmTests.Medium
{
    public class PermutationsIITests
    {
        private PermutationsII _member;

        [SetUp]
        public void SetUp()
        {
            _member = new PermutationsII();
        }

        /// <summary>
        /// 1 <= nums.length <= 8
        /// -10 <= nums[i] <= 10
        /// <summary>
        [Test]
        public void PermuteUnique()
        {

            int[] nums1 = new int[] { 1, 1, 2 };
            int[] nums2 = new int[] { 1, 2, 3 };
            int[] nums3 = new int[] { 1, 2, 3, 1, 1 };
            int[] nums4 = new int[] { -10, 10, 0,5,0,0,-10,0 };
            int[] nums5 = new int[] {};
            int[] nums6 = new int[] {2,1,2,1};
            IList<IList<int>> list1 = _member.PermuteUnique(nums1);
            IList<IList<int>> list2 = _member.PermuteUnique(nums2);
            IList<IList<int>> list3 = _member.PermuteUnique(nums3);
            IList<IList<int>> list4 = _member.PermuteUnique(nums4);
            IList<IList<int>> list5 = _member.PermuteUnique(nums5);
            IList<IList<int>> list6 = _member.PermuteUnique(nums6);

            //expected:
            //  [[1,1,2],[1,2,1],[2,1,1]]
            //  [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
            foreach (var item in list1)
            {
                Console.Write(MyFormat.Convert(item) + " ");
            }
            Console.WriteLine();
            foreach (var item in list2)
            {
                Console.Write(MyFormat.Convert(item) + " ");
            }
            Console.WriteLine();
            foreach (var item in list3)
            {
                Console.Write(MyFormat.Convert(item) + " ");
            }
            Console.WriteLine();
            //foreach (var item in list4)
            //{
            //    Console.Write(MyFormat.Convert(item) + " ");
            //}
            //Console.WriteLine();
            foreach (var item in list5)
            {
                Console.Write(MyFormat.Convert(item) + " ");
            }
            Console.WriteLine();
            foreach (var item in list6)
            {
                Console.Write(MyFormat.Convert(item) + " ");
            }
        }
    }
}

