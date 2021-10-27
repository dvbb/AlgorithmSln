using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Medium
{
    public class ContainerWithMostWater
    {
        /// <summary>
        /// Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate(i, ai). 
        /// n vertical lines are drawn such that the two endpoints of the line i is at(i, ai) and(i, 0). 
        /// Find two lines, which, together with the x-axis forms a container, such that the container contains the most water.
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int MaxArea(int[] height)
        {
            int i = 0;
            int j = height.Length - 1;
            int result = height[i] > height[j] ? (j - i) * height[j] : (j - i) * height[i];
            while (i != j)
            {
                if (height[i] > height[j])
                {
                    j--;
                }
                else
                {
                    i++;
                }
                int temp = height[i] > height[j] ? (j - i) * height[j] : (j - i) * height[i];
                result = temp > result ? temp : result;
            }
            return result;
        }
    }
}
