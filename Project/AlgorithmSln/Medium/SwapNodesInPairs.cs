using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Medium
{
    public class SwapNodesInPairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null) return null;
            if (head.next == null) return head;
            ListNode pre = new ListNode(-1, new ListNode());
            ListNode cur = head;
            ListNode pointer1 = head;
            ListNode pointer2 = head.next;
            head = pointer2;
            while (cur != null && pointer2 != null)
            {
                cur = cur.next.next;
                pointer2.next = pointer1;
                pre.next = pointer2;
                pointer1.next = cur;
                pre = pointer1;
                pointer1 = cur;
                pointer2 = cur?.next;
            }
            return head;
        }


        /// <summary>
        /// ref: https://leetcode-cn.com/problems/swap-nodes-in-pairs/solution/c-di-gui-si-lu-by-rookie_-cx5f/
        /// 使用递归
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode SwapPairsV2(ListNode head)
        {
            //递归结束判断
            if (head?.next == null)
                return head;
            //替换
            var val = head.next.val;
            head.next.val = head.val;
            head.val = val;
            //递归
            SwapPairs(head.next.next);
            return head;
        }
    }
}
