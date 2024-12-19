using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions._3Sum
{
    internal class SolutionTwo_Better
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            var triplets = new HashSet<(int, int, int)>();
            var length = nums.Length;

            for (int i = 0; i < length; i++)
            {
                var possibleThirds = new HashSet<int>();
                for (int j = i + 1; j < length; j++)
                {
                    var third = -(nums[i] + nums[j]);

                    if (possibleThirds.Contains(third))
                    {
                        var temp = new List<int>() { nums[i], nums[j], third };
                        var ordered = temp.Order().ToList();
                        var tuple = (ordered[0], ordered[1], ordered[2]);
                        triplets.Add(tuple);
                    }

                    possibleThirds.Add(nums[j]);
                }
            }

            return triplets
                .Select(tuple => (IList<int>)new List<int> { tuple.Item1, tuple.Item2, tuple.Item3 })
                .ToList();
        }

    }
}
