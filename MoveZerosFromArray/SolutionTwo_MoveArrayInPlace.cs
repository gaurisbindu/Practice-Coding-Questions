using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.MoveZerosFromArray
{
    internal class SolutionTwo_MoveArrayInPlace
    {
        // Ex: [0, 1, 0, 3, 12]
        // Steps:
        // 1. initialize an integer curser at the first index of array
        // 2. Loop through array and if the given element is non-zero insert at the place of index, increment the index
        // 3. After exiting previous loop, again start a loop at index and continue till the length of array has reached
        // 4. In each iteration fill with zeros and increment index

        public static int[] MoveZerosToEnd(int[] nums)
        {
            var index = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] > 0)
                {
                    nums[index] = nums[i];
                    index++;
                }
            }

            while (index < nums.Length)
            {
                nums[index] = 0;
                index++;
            }

            return nums;
        }

        public static int[] MoveZerosToStart(int[] nums)
        {
            var index = nums.Length - 1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if(nums[i] > 0)
                {
                    nums[index] = nums[i];
                    index--;
                }

            }

            while(index >= 0)
            {
                nums[index] = 0;
                index--;
            }

            return nums;
        }
    }
}
