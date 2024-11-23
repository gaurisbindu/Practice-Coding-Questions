using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.MoveZerosFromArray
{
    internal class SolutionOne_UseHashSet
    {
        public static int[] MoveZerosToEnd(int[] nums)
        {
            var result = new List<int>();
            var zeroElements = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == 0)
                {
                    zeroElements.Add(nums[i]);
                }
                else
                {
                    result.Add(nums[i]);
                }
            }

            for (int i = 0; i < zeroElements.Count; i++)
            {
                result.Add((int)zeroElements[i]);
            }

            return result.ToArray();
        }
    }
}
