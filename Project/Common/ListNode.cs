using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public static ListNode CreateByIntArray(int[] array)
        {
            if (array == null) return null;
            if (array.Length == 1) return new ListNode(array[0]);
            ListNode head = new ListNode(array[0], new ListNode());
            ListNode cur = head;
            for (int i = 1; i < array.Length; i++)
            {
                cur.next = new ListNode(array[i], new ListNode());
                cur = cur.next;
            }
            cur.next = null;
            return head;
        }
    }
}
