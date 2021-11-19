using Algorithm.Medium;
using Common;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlorithmTests.Medium
{
    public class SwapNodesInPairsTests
    {
        private SwapNodesInPairs _member;

        [SetUp]
        public void SetUp()
        {
            _member = new SwapNodesInPairs();
        }

        /// <summary>
        /// The number of nodes in the list is in the range [0, 100].
        /// 0 <= Node.val <= 100
        /// </summary>
        [Test]
        public void SwapPairs()
        {
            ListNode head1 = ListNode.CreateByIntArray(new int[] { 1, 2, 3, 4 });
            ListNode expected1 = ListNode.CreateByIntArray(new int[] { 2, 1, 4, 3 });

            ListNode head2 = ListNode.CreateByIntArray(null);
            ListNode expected2 = ListNode.CreateByIntArray(null);

            ListNode head3 = ListNode.CreateByIntArray(new int[] { 1 });
            ListNode expected3 = ListNode.CreateByIntArray(new int[] { 1 });

            ListNode head4 = ListNode.CreateByIntArray(new int[] { 52, 25, 100, 100, 0, 52, 66 });
            ListNode expected4 = ListNode.CreateByIntArray(new int[] { 25, 52, 100, 100, 52, 0, 66 });

            Assert.AreEqual(MyFormat.Convert(expected1), MyFormat.Convert(_member.SwapPairs(head1)));
            Assert.AreEqual(MyFormat.Convert(expected2), MyFormat.Convert(_member.SwapPairs(head2)));
            Assert.AreEqual(MyFormat.Convert(expected3), MyFormat.Convert(_member.SwapPairs(head3)));
            Assert.AreEqual(MyFormat.Convert(expected4), MyFormat.Convert(_member.SwapPairs(head4)));
        }
    }
}
