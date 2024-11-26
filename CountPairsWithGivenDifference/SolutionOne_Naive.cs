using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.CountPairsWithGivenDifference
{
    internal class SolutionOne_Naive
    {
        public static int PairsWithGivenDifference(int[] nums, int targetDiff)
        {
            int findCompliment = 0;
            int findReverseCompliment = 0;
            int pairsCount = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                findCompliment = nums[i] + targetDiff;
                findReverseCompliment = nums[i] - targetDiff;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == findCompliment || findReverseCompliment == nums[j])
                    {
                        Console.WriteLine($"[{nums[i]}, {nums[j]}]");
                        pairsCount++;
                    }
                }
            }

            return pairsCount;
        }
    }
}
