using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.RotateArrayByGivenSteps
{
    internal class SolutionOne
    {
        public static int[] RotateArrayByGivenSteps(int[] nums, int steps)
        {
            steps++;

            int[] result = new int[nums.Length];

            int[] toRotate = new int[steps];
            int[] toKeep = new int[nums.Length - steps];

            for (int i = 0; i < steps; i++)
            {
                toRotate[i] = nums[i];
            }

            var keepIndex = 0;
            for(int i = steps; i < nums.Length; i++)
            {
                toKeep[keepIndex] = nums[i];
                keepIndex++;
            }

            int numIndex = 0;
            while (numIndex < toKeep.Length)
            {
                result[numIndex] = toKeep[numIndex];
                numIndex++;
            }

            var rotateIndex = 0;
            while (numIndex < nums.Length)
            {
                result[numIndex] = toRotate[rotateIndex];
                rotateIndex++;
                numIndex++;
            }

            return result;
        }
    }
}
