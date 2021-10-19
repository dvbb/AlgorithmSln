using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSln
{
    //35. Search Insert Position(Easy)
    //Given a sorted array of distinct integers and a target value, return the index if the target is found.If not, return the index where it would be if it were inserted in order.
    //You must write an algorithm with O(log n) runtime complexity.

    //Example 1:
    //Input: nums = [1,3,5,6], target = 5
    //Output: 2
     public class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target || nums[i] > target)
                {
                    return i;
                }
            }
            return nums.Length;
        }
    }
}
