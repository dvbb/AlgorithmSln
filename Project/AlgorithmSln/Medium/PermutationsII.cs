using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Medium
{
    public class PermutationsII
    {
        /// <summary>
        /// 47.Given a collection of numbers, nums, that might contain duplicates, return all possible unique permutations in any order.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            if (nums is null || nums.Length == 0)
                return new List<IList<int>>() { };
            Validation.Clear();
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>() { };
            LinkedList<int> line = new LinkedList<int>();
            BackTrack(result, nums, line);
            return result;
        }
        private static void BackTrack(IList<IList<int>> result, int[] nums, LinkedList<int> line)
        {
            if (line.Count == nums.Length)
            {
                string strLine = Format(new List<int>(line).ToArray());
                if (!Validation.Contains(strLine))
                {
                    Validation.Add(strLine);
                    result.Add(new List<int>(line));
                }
                return;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= 90)
                {
                    continue;
                }
                line.AddLast(nums[i]);
                nums[i] += 100;
                BackTrack(result, nums, line);
                nums[i] -= 100;
                //line.Remove(nums[i]);
                line.RemoveLast();
            }
        }
        private static List<string> Validation = new List<string>();
        private static string Format(int[] nums)
        {
            string result = "";
            foreach (var item in nums)
            {
                result += item;
            }
            return result;
        }
    }
}
