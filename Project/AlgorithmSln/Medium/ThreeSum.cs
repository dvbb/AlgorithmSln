using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Medium
{
    public class ThreeSum
    {
        #region GetThreeSumV1
        /// <summary>
        /// Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
        /// Notice that the solution set must not contain duplicate triplets.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> GetThreeSum(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>() { };
            Hashtable ht = new Hashtable();
            nums = BubbleSort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (!ht.ContainsKey($"{nums[i]},{nums[j]}"))
                    {
                        ht.Add($"{nums[i]},{nums[j]}", nums[i] + nums[j]);
                    }
                }
            }
            Hashtable isUnique = new Hashtable();
            foreach (var item in ht.Keys)
            {
                string[] strs = ((string)item).Split(',');
                var ergodicNum = MyExcept(nums, strs);
                foreach (var num in ergodicNum)
                {
                    if (num == (int)ht[item] * -1)
                    {
                        int[] keynums = new int[] { int.Parse(strs[0]), int.Parse(strs[1]) };
                        if (keynums[0] + keynums[1] >= 0)
                        {
                            int[] curnums1 = new int[] { num, keynums[0], keynums[1] };
                            if (!isUnique.ContainsKey($"{num},{keynums[0]},{keynums[1]}") && num <= keynums[0] && keynums[0] <= keynums[1])
                            {
                                isUnique.Add($"{num},{keynums[0]},{keynums[1]}", "");
                                List<int> line1 = new List<int>(curnums1);
                                result.Add(line1);
                            }
                        }
                        else
                        {
                            int[] curnums2 = new int[] { keynums[0], keynums[1], num };
                            if (!isUnique.ContainsKey($"{keynums[0]},{keynums[1]},{num}") && keynums[0] <= keynums[1] && keynums[1] <= num)
                            {
                                isUnique.Add($"{keynums[0]},{keynums[1]},{num}", "");
                                List<int> line2 = new List<int>(curnums2);
                                result.Add(line2);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public int[] BubbleSort(int[] nums)
        {
            int temp;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] > nums[i])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            return nums;
        }
        public static List<int> MyExcept(int[] nums, string[] strs)
        {
            bool flag0 = true;
            bool flag1 = true;
            List<int> result = new List<int>();
            foreach (var item in nums)
            {
                if (item.ToString() == strs[0] && flag0)
                {
                    flag0 = false;
                    continue;
                }
                if (item.ToString() == strs[1] && flag1)
                {
                    flag1 = false;
                    continue;
                }
                result.Add(item);
            }
            return result;
        }
        #endregion

        #region GetThreeSumV2
        /// <summary>
        /// ref:https://leetcode-cn.com/problems/3sum/solution/pai-xu-shuang-zhi-zhen-fa-by-zclmoon-o7ur/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> GetThreeSumV2(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums == null || nums.Length < 3) return result;
            Array.Sort(nums); //Time Complexity: O(nlogn)
            for (int cur = 0; cur < nums.Length - 2; cur++)
            {
                if (nums[cur] > 0)
                {
                    break;
                }
                if (cur > 0 && nums[cur] == nums[cur - 1]) continue;
                int i = cur + 1;
                int j = nums.Length - 1;
                while (i < j)
                {
                    int sum = nums[cur] + nums[i] + nums[j];

                    if (sum < 0)
                    {
                        while (i < j && nums[i] == nums[++i]);
                    }
                    else if (sum > 0)
                    {
                        while (i < j && nums[j] == nums[--j]);
                    }
                    else
                    {
                        result.Add(new List<int>() { nums[cur], nums[i], nums[j] });
                        while (i < j && nums[i] == nums[++i]) ; 
                        while (i < j && nums[j] == nums[--j]) ; 
                    }
                }
            }
            return result;
        }
        #endregion
    }
}
