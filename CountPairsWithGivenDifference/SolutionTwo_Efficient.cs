using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.CountPairsWithGivenDifference
{
    internal class SolutionTwo_Efficient
    {
        public static int PairsWithGivenDifference(int[] nums, int targetDiff)
        {
            int pairsCount = 0;

            var compliments = new HashSet<int>();
            foreach (int item in nums)
            {
                compliments.Add(targetDiff + item);
                compliments.Add(item - targetDiff);
            }

            foreach (int item in nums)
            {
                if (compliments.Contains(item))
                {
                    pairsCount++;
                }
            }


            return pairsCount;
        }
    }
}
