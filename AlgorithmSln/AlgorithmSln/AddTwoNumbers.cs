using AlgorithmSln.Interface;
using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSln
{
    public class AddTwoNumbers : IAddTwoNumbers
    {
        //2. Add Two Numbers    [Medium]
        //You are given two non-empty linked lists representing two non-negative integers.
        //The digits are stored in reverse order, and each of their nodes contains a single digit.Add the two numbers and return the sum as a linked list.
        //You may assume the two numbers do not contain any leading zero, except the number 0 itself.

        //input：l1 = [2,4,3], l2 = [5,6,4]
        //output：[7,0,8]
        //because：342 + 465 = 807.
        public ListNode Add(ListNode l1, ListNode l2)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            int result1 = 0;
            int result2 = 0;
            int temp = 1;
            while (l1.next != null)
            {
                list1.Add(l1.val);
            }
            for (int i = 0; i < list1.Count; i++)
            {
                result1 += list1[i] * temp;
                temp *= 10;
            }
            temp = 1;
            while (l2.next != null)
            {
                list1.Add(l2.val);
            }
            for (int i = 0; i < list2.Count; i++)
            {
                result2 += list2[i] * temp;
                temp *= 10;
            }
            int sum = result1 + result2;

            ListNode result = new ListNode(sum % 10, null);
            ListNode cur = result ;
            sum -= sum % 10;
            temp = 100;
            int val;
            while (sum>0)
            {
                val = sum % temp;
                sum -= val;
                cur.next = new ListNode(val*10/temp,null);
                cur = cur.next;
            }
 
            return result;
        }
    }
}
