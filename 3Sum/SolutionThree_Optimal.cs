using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions._3Sum
{
    internal class SolutionThree_Optimal
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            nums = nums.Order().ToArray();

            var result = new List<IList<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int j = i + 1;
                int k = nums.Length - 1;

                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if (sum > 0)
                    {
                        k--;
                    }
                    else if (sum < 0)
                    {
                        j++;
                    }
                    else
                    {
                        result.Add(new List<int>() { nums[i], nums[j], nums[k] });
                        j++;
                        k--;
                        while (j < k && nums[j - 1] == nums[j]) j++;
                        while (j < k && nums[k + 1] == nums[k]) k--;
                    }
                }
            }

            return result;
        }
    }
}
