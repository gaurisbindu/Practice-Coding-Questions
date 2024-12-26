// Question - Given a sorted array of integers and an integer called target, find the element that equals the target and return its index.
// If the element is not found, return -1.

namespace Practice_Coding_Questions.FindElementInSortedArray
{
    internal partial class Program
    {
        public class SolutionTwo_Efficient
        {
            public static int FindElementInArray(int[] nums, int target)
            {
                var start = 0;
                var end = nums.Length - 1;

                while(start <= end)
                {
                    var middle = start + (end - start)/2;
                    if(nums[middle] == target)
                        return middle;
                    else if(nums[middle] > target)
                        end = middle -1;
                    else
                        start = middle + 1;
                
                }


                return -1;
            }
        }
    }
}
