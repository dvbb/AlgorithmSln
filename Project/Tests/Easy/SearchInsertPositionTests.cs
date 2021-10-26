using AlgorithmSln;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlorithmTests.Easy
{
    class SearchInsertPositionTests
    {
        private SearchInsertPosition _SearchInsertPosition;

        [SetUp]
        public void SetUp()
        {
            _SearchInsertPosition = new SearchInsertPosition();
        }
        [Test]
        public void  SearchInsertPositionTest()
        {
            int[] nums1 = new int[4] { 1, 3, 5, 6 };
            int[] nums2 = new int[1] { 1 };
            int target1 = 5;
            int target2 = 2;
            int target3 = 7;
            int target4 = 0;
            int target5 = 0;
            Assert.AreEqual(2, _SearchInsertPosition.SearchInsert(nums1, target1));
            Assert.AreEqual(1, _SearchInsertPosition.SearchInsert(nums1, target2));
            Assert.AreEqual(4, _SearchInsertPosition.SearchInsert(nums1, target3));
            Assert.AreEqual(0, _SearchInsertPosition.SearchInsert(nums1, target4));
            Assert.AreEqual(0, _SearchInsertPosition.SearchInsert(nums2, target5));
        }
    }
}
