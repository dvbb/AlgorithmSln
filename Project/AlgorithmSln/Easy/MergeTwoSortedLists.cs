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
            ListNode result =new ListNode(0, new ListNode()); ;
            ListNode cur = result;
            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    cur.next = new ListNode(l1.val, new ListNode());
                    cur = cur.next;
                    l1 = l1.next;
                }
                else
                {
                    cur.next = new ListNode(l2.val, new ListNode());
                    cur = cur.next;
                    l2 = l2.next;
                }
            }
            cur.next = l1 == null ? l2 : l1;
            return result.next;
        }

        /// <summary>
        /// Recursive
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode MergeTwoListsV2(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            if (l1.val < l2.val)
            {
                l1.next = MergeTwoListsV2(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoListsV2(l1, l2.next);
                return l2;
            }
        }

    }
}
