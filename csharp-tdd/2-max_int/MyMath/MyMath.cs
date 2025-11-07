using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Provides mathematical operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Returns the maximum integer in a list
        /// </summary>
        /// <param name="nums">List of integers</param>
        /// <returns>Maximum integer in the list, or 0 if list is empty</returns>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
                return 0;

            int max = nums[0];
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
            }
            return max;
        }
    }
}