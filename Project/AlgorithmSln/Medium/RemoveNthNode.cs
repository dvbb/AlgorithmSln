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

        /// <summary>
        /// double pointer
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public ListNode RemoveNthFromEndV2(ListNode head, int n)
        {
            if (head.next == null) return null;
            ListNode pre = new ListNode();
            ListNode cur = head;
            pre.next = head;
            int total = 1;
            while (cur.next !=null)
            {
                total++;
                cur = cur.next;
            }
            cur = pre;
            for (int i = 0; i < total-n; i++)
            {
                cur = cur.next;
            }
            if (total - n == 0) return head.next;
            cur.next = cur.next.next;
            return head;
        }
    }
}
