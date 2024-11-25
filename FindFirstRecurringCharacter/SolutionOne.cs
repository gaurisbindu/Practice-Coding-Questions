using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.FindFirstRecurringCharacter
{
    internal class SolutionOne
    {
        private static HashSet<int> _occurances = new HashSet< int>();

        public static int? FindFirstRecurringCharacter(int[] nums)
        {
           if(!nums.Any()) 
                return null;

            for (int i = 0; i< nums.Length; i++)
            {
                if (_occurances.Contains(nums[i]))
                    return nums[i];
                else
                    _occurances.Add(nums[i]);
            }

            return null;
        }
    }
}
