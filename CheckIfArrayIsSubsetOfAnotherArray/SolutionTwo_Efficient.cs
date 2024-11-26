using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.CheckIfArrayIsSubsetOfAnotherArray
{
    internal class SolutionTwo_Efficient
    {
        public static bool CheckForArraySubset(int[] nums1, int[] nums2)
        {
            if (!nums1.Any() && !nums2.Any())
                return true;

            if (!nums1.Any() && nums2.Any())
                return false;

            if (nums1.Any() && !nums2.Any())
                return true;

            var firstArrayElements = new HashSet<int>();

            foreach (var item in nums1)
            {
                firstArrayElements.Add(item);
            }

            var result = true;
            foreach (var item in nums2)
            {
                if(!firstArrayElements.Contains(item))
                {
                    result = false; 
                    break;
                }
            }

            return result;
        }
    }
}
