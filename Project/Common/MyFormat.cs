using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public static class MyFormat
    {
        public static string Format(int[] nums)
        {
            string result = "[";
            for (int i = 0; i < nums.Length - 1; i++)
            {
                result += nums[i] + ",";
            }
            result += nums[nums.Length - 1] + "]";
            return result;
        }

        public static string NodeToString(ListNode head)
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

        public static string IntegerArrayToString(int[] nums)
        {
            if (nums.Length == 0) return "[]";
            string str = "[";
            for (int i = 0; i < nums.Length; i++)
            {
                str += nums[i] + ",";
            }
            return str.Substring(0, str.Length - 1) + "]";
        }

        public static string IntegerArrayToString(int[] nums, int length)
        {
            if (nums.Length == 0) return "[]";
            string str = "[";
            for (int i = 0; i < length; i++)
            {
                str += nums[i] + ",";
            }
            return str.Substring(0, str.Length - 1) + "]";
        }
    }
}
