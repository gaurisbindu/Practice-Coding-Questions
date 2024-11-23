using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.FindMaximumSumSubarray
{
    internal class SolutionTwo_KadanesAlgo
    {
        // Ex: [2, 3, -8, 7, -1, 2, 3]
        // Steps:
        // 1. Initialize result and maxEnding as first element of the array (result = 2, maxEnding = 2)
        // 2. Extend the maximum subarray ending at the previous element by adding current element to it (result = 5, maxEnding = 5)
        // 3. Extend the maximum subarray ending at the previous element by adding curent element to it (result = 5, maxEnding = -3)
        // 4. Since the maximum subarray sum ending at previous element is negative it is better to start the new subarray starting from current element (result=7, maxEnding=7)
        // 5. Extend the maximum subarray ending at the previous element by adding curent element to it (result = 7, maxEnding = 6)
        // 6. Extend the maximum subarray ending at the previous element by adding curent element to it (result = 8, maxEnding = 8)
        // 7 Extend the maximum subarray ending at the previous element by adding curent element to it (result = 11, maxEnding = 11)

        public static int FindMaximumSumInSubarray(int[] nums)
        {
            if(!nums.Any())
            {
                return 0;
            }

            int result = nums[0];
            int maxEnding = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
               maxEnding = maxEnding + nums[i];

                if(maxEnding < 0)
                {
                    maxEnding = nums[i];
                }

               result = Math.Max(result, maxEnding);
            }


            return result;
        }
    }
}
