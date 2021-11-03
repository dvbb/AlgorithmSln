using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Medium
{
    public class RemoveNthNode
    {

        /* Definition for singly-linked list.*/
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }

        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode cur = head;
            int i = 0;
            Dictionary<int, ListNode> dic = new Dictionary<int, ListNode>();
            do
            {
                dic.Add(i++, cur);
                cur = cur.next;
            } while (cur != null);
            if (dic.Count == 1) return null;
            int target = dic.Count - n;
            if (target == 0)
            {
                head = head.next;
            }
            else
            {
                dic[target-1].next = dic[target].next;
            }
            return head;
        }
    }
}
