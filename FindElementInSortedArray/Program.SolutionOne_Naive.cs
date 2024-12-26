// Question - Given a sorted array of integers and an integer called target, find the element that equals the target and return its index.
// If the element is not found, return -1.

namespace Practice_Coding_Questions.FindElementInSortedArray
{
    internal partial class Program
    {
        public class SolutionOne_Naive
        {
            public static int FindElementInArray(int[] nums, int target)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (target == nums[i])
                        return i;
                }

                return -1;

            }
        }
    }
}
