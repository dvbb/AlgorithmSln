using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Medium
{
    public class Permutations
    {
        /// <summary>
        /// Given an array nums of distinct integers, return all the possible permutations. You can return the answer in any order.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> Permute(int[] nums)
        {
            if (nums.Length == 0 || nums == null)
                return new List<IList<int>>() { };
            IList<IList<int>> result = new List<IList<int>>() { };
            LinkedList<int> line = new LinkedList<int>();
            BackTrack(result, nums, line);
            return result;
        }
        private static void BackTrack(IList<IList<int>> result, int[] nums, LinkedList<int> line)
        {
            if (line.Count == nums.Length)
            {
                result.Add(new List<int>(line));
                return;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (line.Contains(nums[i]))
                {
                    continue;
                }
                line.AddLast(nums[i]);
                BackTrack(result, nums, line);
                line.Remove(nums[i]);
            }
        }
    }
}
