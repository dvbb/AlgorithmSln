using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSln
{
    public class SumOfTwoNumbers
    {
        //intpu：nums = [2,7,11,15], target = 9
        //output：[0,1]
        //because： nums[0] + nums[1] == 9 ，return [0, 1]

        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            Hashtable ht = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                ht.Add(nums[i],i);
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
