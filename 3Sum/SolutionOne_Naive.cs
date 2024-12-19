using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions._3Sum
{
    internal class SolutionOne_Naive
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {

            var triplets = new HashSet<(int, int, int)>();
            var length = nums.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    for (int k = j + 1; k < length; k++)
                    {
                        var sum = nums[i] + nums[j] + nums[k];
                        if (sum == 0)
                        {
                            var temp = new List<int>() { nums[i], nums[j], nums[k] };
                            var ordered = temp.Order().ToList();
                            var tuple = (ordered[0], ordered[1], ordered[2]);

                            triplets.Add(tuple);
                            //Console.WriteLine("{0} {1} {2}", nums[i], nums[j], nums[k]);
                        }
                    }
                }
            }

            return triplets
                .Select(tuple => (IList<int>)new List<int> { tuple.Item1, tuple.Item2, tuple.Item3 })
                .ToList();
        }
    }
}
