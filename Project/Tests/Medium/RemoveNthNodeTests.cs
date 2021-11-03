using Algorithm.Medium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using static Algorithm.Medium.RemoveNthNode;

namespace AlorithmTests.Medium
{
    public class RemoveNthNodeTests
    {
        private RemoveNthNode _member;

        [SetUp]
        public void SetUp()
        {
            _member = new RemoveNthNode();
        }
        private ListNode SetUpListNode(int total, bool isRandom = false)
        {
            if (total ==1)
            {
                return new ListNode(1);
            }
            ListNode head = new ListNode(1, new ListNode());
            ListNode cur = head;
            for (int i = 2; i <= total; i++)
            {
                if (i == total)
                {
                    cur.next = new ListNode(i);
                    break;
                }
                cur.next = new ListNode(i, new ListNode());
                cur = cur.next;
            }
            return head;
        }

        private ListNode GetHead5()
        {
            //head5: 52 -> 8 -> 97 -> 100 -> 74
            ListNode head = new ListNode(52, new ListNode());
            head.next = new ListNode(8, new ListNode());
            head.next.next = new ListNode(97, new ListNode());
            head.next.next.next = new ListNode(100, new ListNode());
            head.next.next.next.next = new ListNode(74);
            return head;
        }

        private ListNode GetExpected1()
        {
            ListNode head = new ListNode(1, new ListNode());
            head.next = new ListNode(2, new ListNode());
            head.next.next = new ListNode(3, new ListNode());
            head.next.next.next = new ListNode(5);
            return head;
        }

        private ListNode GetExpected5()
        {
            //head5: 52 -> 8 -> 97 -> 74
            ListNode head = new ListNode(52, new ListNode());
            head.next = new ListNode(8, new ListNode());
            head.next.next = new ListNode(97, new ListNode());
            head.next.next.next= new ListNode(74);
            return head;
        }
        
        private string NodeToString(ListNode head)
        {
            if (head == null) return "[]";
            string str = "[";
            ListNode cur = head;
            do
            {
                str += cur.val + ",";
                cur = cur.next;
            } while (cur != null);
            return str.Substring(0, str.Length - 1) + "]";
        }

        /// <summary>
        /// The number of nodes in the list is sz.
        /// 1 <= sz <= 30
        /// 0 <= Node.val <= 100
        /// 1 <= n <= sz
        /// </summary>
        [Test]
        public void RemoveNthFromEnd()
        {
            ListNode head1 = SetUpListNode(5);   //head1: 1 -> 2 -> 3 -> 4 -> 5
            ListNode head2 = SetUpListNode(1);   //head2: 1
            ListNode head3 = SetUpListNode(2);   //head3: 1 -> 2
            ListNode head4 = SetUpListNode(2);   //head4: 1 -> 2
            ListNode head5 = GetHead5();         //head5: 52 -> 8 -> 97 -> 100 -> 74
            ListNode expected1 = GetExpected1();    //expected1: 1 -> 2 -> 3 -> 5
            ListNode expected2 = null;    //expected2:
            ListNode expected3 = SetUpListNode(1);  //expected3: 1
            ListNode expected4 = new ListNode(2);   //expected4: 2
            ListNode expected5 = GetExpected5();    //expected5: 52 -> 8 -> 97 -> 74
            Assert.AreEqual(NodeToString(expected1), NodeToString(_member.RemoveNthFromEnd(head1, 2)));
            Assert.AreEqual(NodeToString(expected2), NodeToString(_member.RemoveNthFromEnd(head2, 1)));
            Assert.AreEqual(NodeToString(expected3), NodeToString(_member.RemoveNthFromEnd(head3, 1)));
            Assert.AreEqual(NodeToString(expected4), NodeToString(_member.RemoveNthFromEnd(head4, 2)));
            Assert.AreEqual(NodeToString(expected5), NodeToString(_member.RemoveNthFromEnd(head5, 2)));
        }

        [Test]
        public void RemoveNthFromEndV2()
        {
            ListNode head1 = SetUpListNode(5);   //head1: 1 -> 2 -> 3 -> 4 -> 5
            ListNode head2 = SetUpListNode(1);   //head2: 1
            ListNode head3 = SetUpListNode(2);   //head3: 1 -> 2
            ListNode head4 = SetUpListNode(2);   //head4: 1 -> 2
            ListNode head5 = GetHead5();         //head5: 52 -> 8 -> 97 -> 100 -> 74
            ListNode expected1 = GetExpected1();    //expected1: 1 -> 2 -> 3 -> 5
            ListNode expected2 = null;    //expected2:
            ListNode expected3 = SetUpListNode(1);  //expected3: 1
            ListNode expected4 = new ListNode(2);   //expected4: 2
            ListNode expected5 = GetExpected5();    //expected5: 52 -> 8 -> 97 -> 74
            Assert.AreEqual(NodeToString(expected1), NodeToString(_member.RemoveNthFromEndV2(head1, 2)));
            Assert.AreEqual(NodeToString(expected2), NodeToString(_member.RemoveNthFromEndV2(head2, 1)));
            Assert.AreEqual(NodeToString(expected3), NodeToString(_member.RemoveNthFromEndV2(head3, 1)));
            Assert.AreEqual(NodeToString(expected4), NodeToString(_member.RemoveNthFromEndV2(head4, 2)));
            Assert.AreEqual(NodeToString(expected5), NodeToString(_member.RemoveNthFromEndV2(head5, 2)));
        }
    }
}
