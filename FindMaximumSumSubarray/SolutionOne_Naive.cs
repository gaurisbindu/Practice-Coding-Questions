using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.FindMaximumSumSubarray
{
    internal class SolutionOne_Naive
    {
        public static int FindMaximumSumInSubarray(int[] nums)
        {
            // Assume the maximum sum is just the first number in array
            int result = nums[0];

            // Iterate over array once
            for (int i = 0; i < nums.Length; i++)
            {
                int currentSum = 0;

                // Iterate over array for each if the remaining elements and add them together
                for (int j = i; j<nums.Length; j++)
                {
                    currentSum = currentSum + nums[j];
                    
                }

                // update reult if the subarray addaition above is greater than what is in calculated previously
                result = Math.Max(result, currentSum);
            }

            return result;
        }
    }
}
