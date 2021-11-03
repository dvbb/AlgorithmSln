using Algorithm.Easy;
using Common;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlorithmTests.Easy
{
    public class MergeTwoSortedListTests
    {
        private MergeTwoSortedLists _member;

        [SetUp]
        public void SetUp()
        {
            _member = new MergeTwoSortedLists();
        }

        /// <summary>
        /// The number of nodes in both lists is in the range [0, 50].
        /// -100 <= Node.val <= 100
        /// Both l1 and l2 are sorted in non-decreasing order.
        /// </summary>
        [Test]
        public void MergeTwoLists()
        {
            //l1 = [1, 2, 4], l2 = [1, 3, 4]
            ListNode inputL11 = ListNode.CreateByIntArray(new int[] { 1, 2, 4 });
            ListNode inputL12 = ListNode.CreateByIntArray(new int[] { 1, 3, 4 });
            ListNode expectedList1 = ListNode.CreateByIntArray(new int[] { 1, 1, 2, 3, 4, 4 });

            //l1 = [], l2 = []
            ListNode inputL21 = ListNode.CreateByIntArray(null);
            ListNode inputL22 = ListNode.CreateByIntArray(null);
            ListNode expectedList2 = ListNode.CreateByIntArray(null);

            //l1 = [], l2 = [0]
            ListNode inputL31 = ListNode.CreateByIntArray(null);
            ListNode inputL32 = ListNode.CreateByIntArray(new int[] { 0 });
            ListNode expectedList3 = ListNode.CreateByIntArray(new int[] { 0 });

            //l1 = [-100,-2,0,1,1,25,100], l2 = [-75,-22,1]
            ListNode inputL41 = ListNode.CreateByIntArray(new int[] { -100, -2, 0, 1, 1, 25, 100 });
            ListNode inputL42 = ListNode.CreateByIntArray(new int[] { -75, -22, 1 });
            ListNode expectedList4 = ListNode.CreateByIntArray(new int[] { -100,-75, -22,-2, 0,1, 1, 1, 25, 100 });

            Assert.AreEqual(MyFormat.NodeToString(expectedList1), MyFormat.NodeToString(_member.MergeTwoLists(inputL11, inputL12)));
            Assert.AreEqual(MyFormat.NodeToString(expectedList2), MyFormat.NodeToString(_member.MergeTwoLists(inputL21, inputL22)));
            Assert.AreEqual(MyFormat.NodeToString(expectedList3), MyFormat.NodeToString(_member.MergeTwoLists(inputL31, inputL32)));
            Assert.AreEqual(MyFormat.NodeToString(expectedList4), MyFormat.NodeToString(_member.MergeTwoLists(inputL41, inputL42)));
        }

        [Test]
        public void MergeTwoListsV2()
        {
            //l1 = [1, 2, 4], l2 = [1, 3, 4]
            ListNode inputL11 = ListNode.CreateByIntArray(new int[] { 1, 2, 4 });
            ListNode inputL12 = ListNode.CreateByIntArray(new int[] { 1, 3, 4 });
            ListNode expectedList1 = ListNode.CreateByIntArray(new int[] { 1, 1, 2, 3, 4, 4 });

            //l1 = [], l2 = []
            ListNode inputL21 = ListNode.CreateByIntArray(null);
            ListNode inputL22 = ListNode.CreateByIntArray(null);
            ListNode expectedList2 = ListNode.CreateByIntArray(null);

            //l1 = [], l2 = [0]
            ListNode inputL31 = ListNode.CreateByIntArray(null);
            ListNode inputL32 = ListNode.CreateByIntArray(new int[] { 0 });
            ListNode expectedList3 = ListNode.CreateByIntArray(new int[] { 0 });

            //l1 = [-100,-2,0,1,1,25,100], l2 = [-75,-22,1]
            ListNode inputL41 = ListNode.CreateByIntArray(new int[] { -100, -2, 0, 1, 1, 25, 100 });
            ListNode inputL42 = ListNode.CreateByIntArray(new int[] { -75, -22, 1 });
            ListNode expectedList4 = ListNode.CreateByIntArray(new int[] { -100, -75, -22, -2, 0, 1, 1, 1, 25, 100 });

            Assert.AreEqual(MyFormat.NodeToString(expectedList1), MyFormat.NodeToString(_member.MergeTwoListsV2(inputL11, inputL12)));
            Assert.AreEqual(MyFormat.NodeToString(expectedList2), MyFormat.NodeToString(_member.MergeTwoListsV2(inputL21, inputL22)));
            Assert.AreEqual(MyFormat.NodeToString(expectedList3), MyFormat.NodeToString(_member.MergeTwoListsV2(inputL31, inputL32)));
            Assert.AreEqual(MyFormat.NodeToString(expectedList4), MyFormat.NodeToString(_member.MergeTwoListsV2(inputL41, inputL42)));
        }
    }
}
