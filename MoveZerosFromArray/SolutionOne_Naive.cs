using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.ContainDuplicateInArray
{
    internal class SolutionOne_Naive
    {
        public static bool ContainDuplicates(int[] nums)
        {
            HashSet<int> result = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if(result.Contains(nums[i]))
                    return true;
                else
                    result.Add(nums[i]);
            }

            return false;
        }
    }
}
