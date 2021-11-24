using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public static class MyFormat
    {
        public static string Convert<T>(T[] nums)
        {
            if (nums is null || nums.Length == 0) return "[]";
            string str = "[";
            for (int i = 0; i < nums.Length; i++)
            {
                str += nums[i].ToString() + ",";
            }
            return str.Substring(0, str.Length - 1) + "]";
        }

        public static string Convert<T>(T[] nums, int length)
        {
            if (nums is null || nums.Length == 0) return "[]";
            string str = "[";
            for (int i = 0; i < length; i++)
            {
                str += nums[i].ToString() + ",";
            }
            return str.Substring(0, str.Length - 1) + "]";
        }

        public static string Convert<T>(IList<T> list)
        {
            if (list is null || list.Count == 0) return "[]";
            List<T> oblist = new List<T>(list);
            T[] objects = oblist.ToArray();
            string str = "[";
            for (int i = 0; i < objects.Length; i++)
            {
                str += objects[i].ToString() + ",";
            }
            return str.Substring(0, str.Length - 1) + "]";
        }

        public static string Convert(ListNode head)
        {
            if (head == null) return "[]";
            string result = "[";
            while (head != null)
            {
                result += head.val + ",";
                head = head.next;
            }
            return result.Substring(0, result.Length - 1) + "]";
        }
    }
}
