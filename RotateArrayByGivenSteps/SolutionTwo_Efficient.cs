using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.RotateArrayByGivenSteps
{
    internal class SolutionTwo_Efficient
    {
        public static int[] RotateArrayByGivenSteps(int[] nums, int steps)
        {
            if(steps <= 0) 
                return nums;

            if(!nums.Any()) 
                return nums;

            int[] result = new int[nums.Length];

            var numIndex = steps + 1;
            var resultIndex = 0;
            while(numIndex < nums.Length)
            {
                result[resultIndex++] = nums[numIndex++];
            }

            numIndex = 0;
            while(resultIndex < nums.Length)
            {
                result[resultIndex++] = nums[numIndex++];
            }

            return result;
        }
    }
}
