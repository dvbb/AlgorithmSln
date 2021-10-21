using AlgorithmSln.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSln
{
    public class TwoSum : ISumOfTwoNumbers
    {
        //1. Two Sum    [Easy]
        //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        //You may assume that each input would have exactly one solution, and you may not use the same element twice.
        //You can return the answer in any order.

        //intpu：nums = [2,7,11,15], target = 9
        //output：[0,1]
        //because： nums[0] + nums[1] == 9 ，return [0, 1]
        public int[] TwoSumAdd(int[] nums, int target)
        {
            int[] result = new int[2];
            Hashtable ht = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!ht.ContainsKey(nums[i]))
                {
                    ht.Add(nums[i], i);
                    continue;
                }
                //if hashtable contain nums[i],check nums[i] + nums[i] == target is true,return the result
                if (nums[i] + nums[i] == target)
                {
                    result[0] = (int)ht[nums[i]];
                    result[1] = i;
                    return result;
                }
            }
            int diff;
            for (int i = 0; i < nums.Length; i++)
            {
                diff = target - nums[i];
                if (ht.Contains(diff))
                {
                    result[0] = (int)ht[diff];
                    result[1] = i;
                }
            }
            return result;
        }
    }
}
