using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Easy
{
    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null) return null;
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            ListNode pointer1 = l1;
            ListNode pointer2 = l2;
            ListNode result ;
            if (pointer1.val <= pointer2.val)
            {
                result = new ListNode(pointer1.val, new ListNode());
                pointer1 = pointer1.next;
            }
            else
            {
                result = new ListNode(pointer2.val, new ListNode());
                pointer2 = pointer2.next;
            }
            ListNode cur = result;
            while (pointer1 != null && pointer2 != null)
            {
                if (pointer1.val <= pointer2.val)
                {
                    cur.next = new ListNode(pointer1.val, new ListNode());
                    cur = cur.next;
                    pointer1 = pointer1.next;
                }
                else
                {
                    cur.next = new ListNode(pointer2.val, new ListNode());
                    cur = cur.next;
                    pointer2 = pointer2.next;
                }
            }
            while (pointer1 != null)
            {
                cur.next = new ListNode(pointer1.val, new ListNode());
                cur = cur.next;
                pointer1 = pointer1.next;
            }
            while (pointer2 != null)
            {
                cur.next = new ListNode(pointer2.val, new ListNode());
                cur = cur.next;
                pointer2 = pointer2.next;
            }
            cur.next = null;
            return result;
        }
    }
}
